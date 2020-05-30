using dotenv.net;
using System;

namespace OpenWeatherMapSpecFlowProject.Handlers
{
    static class EnvHandler
    {
        /// <summary>
        /// Read the OWA_API_ID from the .env file in the running folder (TestResults)
        /// </summary>
        internal static void SetupEnvVars()
        {
            DotEnv.Config(false);
        }

        /// <summary>
        /// Easy access static variable preventing typing errors whereever it might be called from
        /// </summary>
        public static string OWA_API_ID { get { return GetEnvStringVar("OWA_API_ID"); } }

        private static string GetEnvStringVar(string key)
        {
            var value = Environment.GetEnvironmentVariable(key);

            if (string.IsNullOrWhiteSpace(value))
            {
                var errorMsg = $"No value provided for environment variable {key} key";

                Console.WriteLine(errorMsg);

                throw new NullReferenceException(errorMsg);
            }

            return value;
        }
    }
}
