using System;
using System.Windows.Forms;

namespace EDCodex.Panel
{
    public class Logger
    {
        private readonly RichTextBox _textBox;

        public Logger(RichTextBox textBox)
        {
            _textBox = textBox;
        }

        public bool IsDebugEnabled { get; set; } = true;

        /// <summary>
        /// Logs a general message intended for the user.
        /// </summary>
        public void LogMessage(string message)
        {
            AppendMessage(message);
        }

        /// <summary>
        /// Logs a debug message with a timestamp.
        /// </summary>
        public void Debug(string message)
        {
            if (!IsDebugEnabled)
            {
                return;
            }

            var timestamp = DateTime.Now.ToString("HH:mm:ss");
            AppendMessage($"[{timestamp} DEBUG] {message}");
        }

        /// <summary>
        /// Appends a message to the <see cref="RichTextBox"/> UI control.
        /// </summary>
        private void AppendMessage(string message)
        {
            //Ensure we're updating the TextBox from the UI thread
            //to avoid cross-thread exceptions.
            if (_textBox.InvokeRequired)
            {
                _textBox.BeginInvoke((MethodInvoker)(() => AppendMessage(message)));
                return;
            }

            _textBox.AppendText($"{message}{Environment.NewLine}");
            _textBox.SelectionStart = _textBox.Text.Length;
            _textBox.ScrollToCaret();
        }
    }
}
