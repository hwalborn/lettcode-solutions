using System;

namespace Problems.Algorithms
{
    public class FirstBadVersion : ITest
    {
        public int BadVersion { get; set; }
        private int Solve(int n) {
            var badVersion = n;
            var huh = Huh(n, n);
            
            // while (badVersion > 0)
            // {
            //     var isBadVersion = IsBadVersion(badVersion);
            //     var prevIsGoodVersion = !IsBadVersion(badVersion -1);
            //     if (isBadVersion && prevIsGoodVersion)
            //     {
            //         return badVersion;
            //     }
            //     badVersion = isBadVersion ? (int)Math.Floor((double)badVersion / 2) : (int)Math.Floor((double)((long)n + (long)badVersion) / 2);
            // }
            return 1;
        }

        private int Huh(int badVersion, int n)
        {
            if (badVersion <= 0)
            {
                return 1;
            }
            var isBadVersion = IsBadVersion(badVersion);
            var prevIsGoodVersion = !IsBadVersion(badVersion -1);
            if (isBadVersion && prevIsGoodVersion)
            {
                return badVersion;
            }
            badVersion = isBadVersion ? (int)Math.Floor((double)badVersion / 2) : (int)Math.Floor((double)((long)n + (long)badVersion) / 2);
            return Huh(badVersion, n);
        }

        /**
        * while true
        * same breaks
        * have variable "previousBadVersion"
        */
        public int Bah(int n) {
            var previousBadVersion = n;
            while (true)
            {
                if (!IsBadVersion(n) && IsBadVersion(n+1)) {
                    return n+1;
                } else if (!IsBadVersion(n-1) && IsBadVersion(n)) {
                    return n;
                } else if (IsBadVersion(n)) {
                    decimal additionalAmount = n/2;
                    previousBadVersion = n;
                    n = (int)Math.Floor(additionalAmount);
                } else {
                    var nextCheck = n + Math.Floor((decimal)(previousBadVersion - n) / 2);
                    n = (int)nextCheck;
                }
            }
        }

        private int GetBadVersion(int prev, int curr, bool prevIsBadVersion)
        {
            var isBadVersion = IsBadVersion(curr);
            if (isBadVersion && !prevIsBadVersion && prev == curr - 1)
            {
                return curr <= 0 ? 1 : curr;
            }
            var next = 0;
            if (prevIsBadVersion && !isBadVersion)
            {
                next = (int)Math.Floor((double)(curr + prev) / 2);
            }
            else if (!prevIsBadVersion && !isBadVersion)
            {
                next = curr + prev;
            }
            else
            {
                next = (int)Math.Floor((double)curr / 2);
            }
            return GetBadVersion(curr, next, isBadVersion);
        }

        private bool IsBadVersion(int n) {
            return n >= BadVersion;
        }

        public void Go()
        {
            // BadVersion = 4;
            // Console.WriteLine(Solve(5));
            // BadVersion = 1;
            // Console.WriteLine(Solve(24213245));
            // BadVersion = 56;
            // Console.WriteLine(Solve(58));
            // BadVersion = 1;
            // Console.WriteLine(Solve(1));
            //1595065042
            BadVersion = 1702766719;
            Console.WriteLine(Bah(2126753390));
            // BadVersion = 4;
            // Console.WriteLine(Bah(5));
        }
    }
}
