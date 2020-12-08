using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace CopyFileWhenDone.Classes
{
    /// <summary>
    /// This would be to simulate a copying a file from another application
    /// </summary>
    public class FileOperations
    {
        public delegate void OnIterate(int sender);
        /// <summary>
        /// Provides current iteration value
        /// </summary>
        public static event OnIterate OnIterateEvent;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="originalFile">File to copy</param>
        /// <param name="outputFile">File to copy too</param>
        /// <param name="delay">Milliseconds to delay to simulate a large file</param>
        /// <param name="token">cancellation token to permit cancelling this operation</param>
        /// <returns>Success</returns>
        /// <remarks>
        /// Exception handling is done at client level
        /// </remarks>
        public static async Task<bool> CopyFileTask(string originalFile, string outputFile, int delay, CancellationToken token)
        {
            int lineNumber = 0;
            using (var inputStream = File.OpenRead(originalFile))
            {
                using (var inputReader = new StreamReader(inputStream))
                {
                    using (var outputWriter = File.AppendText(outputFile))
                    {
                        var currentLine = await inputReader.ReadLineAsync();

                        await outputWriter.WriteLineAsync(currentLine);

                        if (delay > 0)
                        {
                            await Task.Delay(delay, token);
                        }

                        while (null != currentLine)
                        {
                            lineNumber += 1;
                            await outputWriter.WriteLineAsync(currentLine);
                            currentLine = await inputReader.ReadLineAsync();
                            OnIterateEvent?.Invoke(lineNumber);
                            if (token.IsCancellationRequested)
                            {
                                token.ThrowIfCancellationRequested();
                            }

                            if (delay > 0)
                            {
                                await Task.Delay(delay, token);
                            }

                        }
                    }
                }
            }

            return true;

        }
    }
}