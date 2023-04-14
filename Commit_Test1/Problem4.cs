using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commit_Test1
{
    internal class Problem4
    {
        public int SumOfDigits(int num)           // 각자릿수 더하는 함수 더하위한 값 입력받기위히 매개변수를 int값으로 받음
        {
            int answer = 0;                       // 처음에 정답을 0으로 초기화해둠
            while (num != 0)                      // 입력받은 값이 0이되면 멈추도록 중단하게 0과같지않을 조건문으로 while문 실행
            {
                answer += num % 10;               // while문을 돌면서 값을 10으로 나눈 나머지값을 answer에 추가해줌
                num /= 10;                        // 추가해준뒤에 뒤쪽값은 필요가없으므로 10으로 나눠주고 int 자료형에 들어갈경우 소수점은 자동 버림
            }
            return answer;                        // while문이 끝났으므로 num값이 0일것이므로 모든 자릿수가 더해짐
        }
    }
}
