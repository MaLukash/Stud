using System;


namespace UnitTestProject1
{
    // консольный писатель
    public class ConsoleWriter
    {
        private ConsoleColor _successColor; // цвет сообщений для успешных операций
        private ConsoleColor _errorColor; // цвет сообщений об ошибках
        private ConsoleColor _warningColor; // цвет сообщений-предупреждений
        private string _successText; // текст сообщений для успешных операций
        private string _errorText; // текст сообщений об ошибках
        private string _warningText; // текст сообщений-предупреждений
        public ConsoleColor SuccessColor
        {
            get { return _successColor; }
            set { _successColor = value; }
        }

        public ConsoleColor ErrorColor
        {
            get { return _errorColor; }
            set { _errorColor = value; }
        }
        public ConsoleColor WarningColor
        {
            get { return _warningColor; }
            set { _warningColor = value; }
        }
        public string SuccessText
        {
            get { return _successText; }
            set { _successText = value; }
        }
        public string ErrorText
        {
            get { return _errorText; }
            set { _errorText = value; }
        }
        public string WarningText
        {
            get { return _warningText; }
            set { _warningText = value; }
        }
        public ConsoleColor ForegroundColor
        {
            get { return Console.ForegroundColor; }
            set { Console.ForegroundColor = value; }
        }
        public ConsoleColor BackgroundColor
        {
            get { return Console.BackgroundColor; }
            set { Console.BackgroundColor = value; }
        }
        public ConsoleWriter()
        {
            _successColor = ConsoleColor.Green;
            _errorColor = ConsoleColor.Red;
            _warningColor = ConsoleColor.Blue;
            _successText = "OK";
            _errorText = "ERROR";
            _warningText = "WARNING";
        }
        public void Write(string value)
        {
            Console.Write(value);
        }
        public void Write(ConsoleColor color, string value)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(value);
            Console.ForegroundColor = oldColor;
        }
        public void Write(string format, params object[] args)
        {
            Console.Write(string.Format(format, args));
        }
        public void Write(ConsoleColor color, string format, params object[] args)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(string.Format(format, args));
            Console.ForegroundColor = oldColor;
        }
        public void WriteLine()
        {
            Console.WriteLine();

        }
        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }
        public void WriteLine(ConsoleColor color, string value)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ForegroundColor = oldColor;
        }
        public void WriteLine(string format, params object[] args)
        {
            Console.WriteLine(string.Format(format, args));
        }
        public void WriteLine(ConsoleColor color, string format, params object[] args)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(string.Format(format, args));
            Console.ForegroundColor = oldColor;
        }
        public void WriteSuccess()
        {
            Write(_successColor, _successText);
        }
        public void WriteSuccess(string value)
        {
            Write(_successColor, value);
        }
        public void WriteSuccess(string format, params object[] args)
        {
            Write(_successColor, string.Format(format, args));
        }
        public void WriteLineSuccess()
        {
            WriteLine(_successColor, _successText);
        }
        public void WriteLineSuccess(string value)
        {
            WriteLine(_successColor, value);
        }
        public void WriteLineSuccess(string format, params object[] args)
        {
            WriteLine(_successColor, string.Format(format, args));
        }
        public void WriteError()
        {

            Write(_errorColor, _errorText);
        }
        public void WriteError(string value)
        {
            Write(_errorColor, value);
        }
        public void WriteError(string format, params object[] args)
        {
            Write(_errorColor, string.Format(format, args));
        }
        public void WriteLineError()
        {
            WriteLine(_errorColor, _errorText);
        }
        public void WriteLineError(string value)
        {
            WriteLine(_errorColor, value);
        }
        public void WriteLineError(string format, params object[] args)
        {
            WriteLine(_errorColor, string.Format(format, args));
        }
        public void WriteWarning()
        {
            Write(_warningColor, _warningText);
        }
        public void WriteWarning(string value)
        {
            Write(_warningColor, value);
        }
        public void WriteWarning(string format, params object[] args)
        {
            Write(_warningColor, string.Format(format, args));
        }
        public void WriteLineWarning()
        {
            WriteLine(_warningColor, _warningText);
        }
        public void WriteLineWarning(string value)
        {
            WriteLine(_warningColor, value);
        }
        public void WriteLineWarning(string format, params object[] args)
        {
            WriteLine(_warningColor, string.Format(format, args));
        }
    }
}