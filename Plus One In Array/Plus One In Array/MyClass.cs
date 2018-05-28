namespace Plus_One_In_Array
{
    public class MyClass
    {
        public static int[] PlusOne(int[] digits)
        {
            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                else if (i == 0)
                {
                    digits[i] = 0;
                    int[] newArr = new int[digits.Length+1];
                    newArr[0] = 1;
                    
                    // TODO can be deleted since the only possible for those number are 0s, no need to copy
                    for (int j = 1; j < newArr.Length; j++)
                    {
                        newArr[j] = digits[j - 1];
                    }
                    
                    return newArr;
                }
                else
                {
                    digits[i] = 0;                    
                }
            }

            return digits;
        }
    }
}