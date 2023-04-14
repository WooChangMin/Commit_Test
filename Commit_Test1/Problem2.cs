using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commit_Test1
{
    internal class Problem2
    {
        public void Test2()
        {
            string str = Console.ReadLine();                    //문자열을 입력받기위한 readline커맨드사용
            string[] words = str.Split(' ');                    //string배열에 스페이스바를 기준으로 나눈 문자열들을 저장함
            Console.WriteLine(words.Length);                    //words 문자열의 길이를 출력 >> 문장에서의 단어수
        }

    }

}
