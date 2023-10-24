namespace DesignPatterns.Tools
{
    public static class LocalConsole
    {
        public static void Clear()
        {
            Program.form.rtbOutput.Text = "©️ ParmisIT. all rights reserved." + Environment.NewLine + Environment.NewLine;
        }

        public static void Write(string text)
        {
            Program.form.rtbOutput.Text += text;
        }
        public static void WriteLine(string text)
        {
            Program.form.rtbOutput.Text += "$> " + text + Environment.NewLine;
        }
        public static void WriteLine()
        {
            Program.form.rtbOutput.Text += Environment.NewLine;
        }
        public static void ClearInfo()
        {
            Program.form.rtbInfo.Text = string.Empty;
        }

        public static void WriteLineInfo(string text)
        {
            Program.form.rtbInfo.Text += text + Environment.NewLine;
        }
    }
}
