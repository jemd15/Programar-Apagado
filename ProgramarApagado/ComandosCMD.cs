using System.Diagnostics;

namespace ProgramarApagado
{

    static class ComandosCMD {

        public static void ProgramarApagado(decimal tiempo) {

            //Indicamos el comando a ejecutar en la consola de comandos
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c shutdown /s /f /t " + tiempo);
            //Indicamos que la salida del proceso se redireccione en un Stream
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            //Indica que el proceso no despliegue una pantalla negra (El proceso se ejecuta en background)
            procStartInfo.CreateNoWindow = true;
            //Esconder la ventana
            procStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //Inicializa el proceso
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();

        }

        public static void CancelarApagado() {

            //Indicamos el comando a ejecutar en la consola de comandos
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c shutdown /a");
            //Indicamos que la salida del proceso se redireccione en un Stream
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            //Indica que el proceso no despliegue una pantalla negra (El proceso se ejecuta en background)
            procStartInfo.CreateNoWindow = true;
            //Esconder la ventana
            procStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //Inicializa el proceso
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();

        }

        public static void ProgramarHibernar(decimal tiempo) {
            //Indicamos el comando a ejecutar en la consola de comandos
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c shutdown /h /f /t " + tiempo);
            //Indicamos que la salida del proceso se redireccione en un Stream
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            //Indica que el proceso no despliegue una pantalla negra (El proceso se ejecuta en background)
            procStartInfo.CreateNoWindow = true;
            //Esconder la ventana
            procStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //Inicializa el proceso
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
        }

    }
}
