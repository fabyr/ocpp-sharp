using System;
using System.Diagnostics;

namespace OcppSharp
{
    public class Log
    {
        private TextWriter @out, err;

        public Log(TextWriter @out, TextWriter err)
        {
            this.@out = @out;
            this.err = err;
        }

        public bool EnableLogging { get; set; } = true;

        private string GetDate(bool dateFormat)
        {
            if(dateFormat)
                return $"{DateTime.Now.ToString("HH:mm:ss")}\t";
            return string.Empty;
        }

        public void Write(string text)
        {
            if(EnableLogging)
                @out.Write(text);
        }

        public void WriteLine(string text, bool dateFormat = true) 
            => Write(GetDate(dateFormat) + text + @out.NewLine);
        
        public void WriteErr(string text)
        {
            if(EnableLogging)
                err.Write(text);
        }

        public void WriteLineErr(string text, bool dateFormat = true) 
            => WriteErr(GetDate(dateFormat) + text + err.NewLine);

        public void WriteWarn(string text)
        {
            // Might add special formatting in future
            if(EnableLogging)
                @out.Write(text);
        }

        public void WriteLineWarn(string text, bool dateFormat = true) 
            => WriteWarn(GetDate(dateFormat) + text + @out.NewLine);
    }
}