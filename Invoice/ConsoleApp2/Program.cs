using System.Diagnostics;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            // --------------------------------
            logger.Info("Just information");
            logger.Warn("Something weird");
            logger.Error("Error");
        }

    }

    public interface ILogger
    {
        void Info(string message);
        void Warn(string message); 
        void Error(string message);
    }

    public abstract class BaseLogger
    {
        protected string FormatMessage(string level, string message)
        {
            var formattedMessage = new StringBuilder(message.Length + 25);
            formattedMessage.Append(DateTime.Now.ToString());
            formattedMessage.Append(' ');
            formattedMessage.Append(level.ToUpper());
            formattedMessage.Append(' ');
            formattedMessage.Append(message);

            return formattedMessage.ToString();

        }
    }

    public class ConsoleLogger : BaseLogger, ILogger
    {
        public void Error (string message)
        {
          var previousColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(FormatMessage("Error", message));
            Console.ForegroundColor = previousColor;
        }
        public void Info(string message)
        {
            Console.WriteLine("INFO: " + message);
        }

        public void Warn(string message)
        {
           var previousColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("WARN: " + message);
            Console.ForegroundColor = previousColor;
        }
 
    }

    public class DebugLogger : BaseLogger, ILogger
    {
        public void Error (string message)
        {
            Debug.WriteLine(FormatMessage("Error", message));
        }
        public void Info(string message)
        {
            Debug.WriteLine(FormatMessage("Info", message));
        }
        public void Warn(string message)
        {
            Debug.WriteLine(FormatMessage("Warn", message));
        }
    }
}