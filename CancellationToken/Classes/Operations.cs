using System.Threading.Tasks;
using static CancellationToken.Classes.DelegatesSignatures;

namespace CancellationToken.Classes
{
    public class Operations
    {
        public event MonitorHandler OnMonitor;
        /// <summary>
        /// Do nothing method to show how to cancel a Task via
        /// CancellationTokenSource
        /// </summary>
        /// <param name="value">int value greater than 0</param>
        /// <param name="token">Initialized cancellation token</param>
        /// <returns></returns>
        public async Task<int> Run(int value, System.Threading.CancellationToken token)
        {
            var currentIndex = 0;

            while (currentIndex <= value -1)
            {

                OnMonitor?.Invoke(new MonitorArgs("Working", currentIndex));

                currentIndex += 1;

                await Task.Delay(1, token);
                
                if (token.IsCancellationRequested) token.ThrowIfCancellationRequested();
            }

            OnMonitor?.Invoke(new MonitorArgs("Done", currentIndex));
            return currentIndex;
        }
    }
}