using System;
using System.Text;
using System.Net;
using System.Security.Cryptography;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace AESChatApp
{
    public partial class Form1 : Form
    {
        private TcpListener server;
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        private Thread sendThread;
        private const int port = 8082; // Cổng mặc định để kết nối
        static string privateKey;
        static string publicKey;
        static string key = "";
        static byte[] byteKey;
        static string plaintext;
        static string ciphertext = "";
        static string ip;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
             ip = txtIP.Text;
            if (ip == "")
            {
                ip = "172.19.247.73";
            }
           
            try
            {
                // Tạo khóa AES 256 bit ngẫu nhiên
                using (Aes aes = Aes.Create())
                {
                    aes.KeySize = 256;
                    aes.Mode = CipherMode.ECB; 
                    aes.Padding = PaddingMode.PKCS7;
                    aes.GenerateKey();
                    byteKey = aes.Key;
                    key = Convert.ToBase64String(aes.Key);
                    
                    string keyHex = BitConverter.ToString(aes.Key).Replace("-", "");
                    textBoxKey.Text = keyHex;

                }
                // Khởi tạo server
                server = new TcpListener(System.Net.IPAddress.Any, port);
                server.Start();

                // Lắng nghe kết nối từ client
                client = server.AcceptTcpClient();
                stream = client.GetStream();
                // Gửi khóa cho client 
                SendData(stream, key);
                //Tạo thread nhận tin nhắn từ client
                receiveThread = new Thread(ReceiveMessages);
                receiveThread.IsBackground = true;
                receiveThread.Start();
                MessageBox.Show("Kết nối thành công!");

                // Tắt nút kết nối sau khi kết nối
                //btnConnect.Enabled = false;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lỗi giải mã khóa chung: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối: " + ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            textBoxEncriptServer.ResetText();
            try
            {
                if (stream != null)
                {
                    string message = txtMessage.Text;
                    string encryptedMessage = AESEncryption.EncryptMessage(message, byteKey); // Mã hóa tin nhắn
                    SendData(stream, encryptedMessage);
                    ciphertext = encryptedMessage;
                    listBoxMessages.EnableChatStyle();
                    listBoxMessages.AddChatMessage("me: " + message, true);
                 
                    txtMessage.Clear(); // Xóa hộp tin nhắn
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi tin nhắn: " + ex.Message);
            }
        }
        

        private void ReceiveMessages()
        {
            try
            {
                while (true)
                {
                    if (stream != null && stream.DataAvailable)
                    {
                        
                        String receiveData = ReceiveData(stream);
                        string decryptedMessage = AESEncryption.DecryptMessage(receiveData, byteKey);
                        //ciphertext = encryptedMessage;
                        Invoke(new MethodInvoker(() =>
                        {
                            textBoxCiphertextClient.Text = receiveData;
                            ciphertext = receiveData;
                            listBoxMessages.EnableChatStyle();
                            listBoxMessages.AddChatMessage($"{ip}: " + decryptedMessage, false);  
                        }));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nhận tin nhắn: " + ex.Message);
            }
        }

        static void SendData(NetworkStream stream, string data)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(data + "\n");
            stream.Write(buffer, 0, buffer.Length);
        }
        static string ReceiveData(NetworkStream stream)
        {
            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            return Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            receiveThread?.Abort();
            stream?.Close();
            client?.Close();
            server?.Stop();
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void ipLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEncriptServer_Click(object sender, EventArgs e)
        {
            string txtServer = txtMessage.Text;

            textBoxEncriptServer.ResetText();
            if (txtServer != "")
            {
                textBoxEncriptServer.Text = AESEncryption.EncryptMessage(txtServer, byteKey);
            } 
            
        }

        private void btnDecryptionServer_Click(object sender, EventArgs e)
        {
            string txtCiphertextServer = textBoxEncriptServer.Text;
            textBoxPlaintextClient.ResetText();
            textBoxPlaintextClient.Text = AESEncryption.DecryptMessage(txtCiphertextServer, byteKey);
        }

        private void btnEncriptionClient_Click(object sender, EventArgs e)
        {
            byte[] keyBytes = AESEncryption.ConvertHexStringTo32ByteArray(textBoxKey.Text);
            if (Convert.ToBase64String(keyBytes) != key)
            {
                MessageBox.Show("Khóa đã bị thay đổi");
            }
            textBoxCiphertextClient.ResetText();
            if (textBoxPlaintextClient.Text != "")
            {
                textBoxCiphertextClient.Text = AESEncryption.EncryptMessage(textBoxPlaintextClient.Text, keyBytes);

            }
        }

        private void btnDecriptionClient_Click(object sender, EventArgs e)
        {
            textBoxPlaintextClient.ResetText();
            byte[] keyBytes = AESEncryption.ConvertHexStringTo32ByteArray(textBoxKey.Text);
            if (Convert.ToBase64String(keyBytes) != key)
            {
                MessageBox.Show("Khóa đã bị thay đổi");
            }
            string message = textBoxCiphertextClient.Text;
            if (message != ciphertext && message != textBoxEncriptServer.Text)
            {
                MessageBox.Show("Bản mã đã bị thay đổi");
            } else if (AESEncryption.DecryptMessage(textBoxCiphertextClient.Text, keyBytes) != "0")
            {
                
                if (textBoxCiphertextClient.Text != "")
                {
                    textBoxPlaintextClient.Text = AESEncryption.DecryptMessage(textBoxCiphertextClient.Text, keyBytes);
                }
            }
            
        }
    }
}
