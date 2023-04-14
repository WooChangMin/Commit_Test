using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commit_Test1
{
    internal class Problem3
    {
        public bool IsPrime(int n)              //소수를 판별하기 위한 함수 숫자의 입력을 받기위해 n값을 매개변수로 받음
        {
            for (int i = 2; i < n; i++)         //포문을 돌려보면서 2에서 입력받은 숫자보다 적을때까지 i를 1개씩올림
            {
                if (n % i == 0)                 //해당포문이돌면서 나머지가 0인경우 소수가 아니므로 false반환
                {
                    return false;
                }
            }
            return true;                        //해당 포문이 끝났을때까지 나머지가 0인경우가 없으므로  true반환
        }
    }
}
