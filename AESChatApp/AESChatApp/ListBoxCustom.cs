using System;
using System.Drawing;
using System.Windows.Forms;

public static class ListBoxExtensions
{
    public static void EnableChatStyle(this ListBox listBox)
    {
        listBox.DrawMode = DrawMode.OwnerDrawFixed;
        listBox.ItemHeight = 25; // Chiều cao dòng
        listBox.DrawItem += (sender, e) =>
        {
            if (e.Index < 0) return;

            // Lấy thông tin tin nhắn
            var item = (ChatMessage)listBox.Items[e.Index];

            // Xóa nền cũ
            e.DrawBackground();

            // Định dạng căn trái/phải
            var textAlignment = item.IsRightAligned ? StringAlignment.Far : StringAlignment.Near;
            var format = new StringFormat
            {
                Alignment = textAlignment,
                LineAlignment = StringAlignment.Center
            };

            // Vẽ tin nhắn
            e.Graphics.DrawString(
                item.Text,
                listBox.Font,
                new SolidBrush(Color.Black),
                e.Bounds,
                format
            );

            e.DrawFocusRectangle();
        };
    }

    public static void AddChatMessage(this ListBox listBox, string message, bool isRightAligned)
    {
        listBox.Items.Add(new ChatMessage { Text = message, IsRightAligned = isRightAligned });
        listBox.TopIndex = listBox.Items.Count - 1; // Auto-scroll đến cuối
    }

    private class ChatMessage
    {
        public string Text { get; set; }
        public bool IsRightAligned { get; set; }
    }
}
