using System;
using System.IO;

namespace Network_Programing_Stream
{
    /* Stream
     * 데이터를 취급하는 것은 프로그램의 가장 중요한 임무의 하나이다. C#에서도 파일, 메모리, 입출력 기기,
     * 프로세스간 통신 파이프, 그리고 네트워크 등 데이터를 저장하고 불러오는 방법은 다양하다.
     * 
     * 스트림은 기본적으로 세 개의 기능 제공
     * 데이터를 스트림으로부터 메모리 버퍼로 전송(읽기)
     * 데이터를 메모리 버퍼로부터 스트림으로 전송(쓰기)
     * 특정 바이트 현태를 스트림으로부터 검색(찾기)
    */
    class Program
    {
        static void Main(string[] args)
        {
            string logFile = "LOGFILE.TXT";

            FileStream fs = new FileStream(logFile,
                FileMode.OpenOrCreate, FileAccess.Write);

            // 기본 방법 입력스트림, 읽기 스트림
            StreamWriter sw = new StreamWriter(fs);
            StreamReader sr = new StreamReader(fs);

            sw.WriteLine("First log entry");
            sw.WriteLine("Second log entry");

            while (sr.Peek() > -1)
            {
                Console.WriteLine(sr.ReadLine());
            }
            // 스트림은 꼭 닫아준다
            sw.Close();
            sr.Close();
            fs.Close();
        }
    }
}
