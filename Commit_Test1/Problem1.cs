using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commit_Test1
{
    internal class Problem1
    {
        public void Test1()
        {
            string str1 = Console.ReadLine();                                  //문자열 입력 받아서 str1에 저장
            string str2 = Console.ReadLine();                                  //비교할 문자열 입력받아 str2에 저장
            int a = str1.IndexOf(str2);                                        // IndexOf 함수를 사용해서 비교하여 가장첫번째 인덱스 반환받아 a에 집어넣음
            if (a == -1)                                                       // a가 -1일 경우 일치하는 문자열이 없다는 것이므로 예외처리
            {
                Console.WriteLine("해당 문자열에서는 문자를 찾을수 없습니다.");
            }
            Console.WriteLine(a);                                              // -1이 아닐경우 정답 인덱스인 a값 반환
        }
    }
}
