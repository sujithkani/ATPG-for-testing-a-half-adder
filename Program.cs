using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ATPG for a Half Adder\n**********************");
        string f_target = "sum";
        int s_a_val = 0;                         //Stuck at zero fault
        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] == "--fault" && i + 1 < args.Length)
                f_target = args[++i].ToLower();
            else if (args[i] == "--stuck" && i + 1 < args.Length)
                s_a_val = int.Parse(args[++i]);
        }
        Console.WriteLine($"Target Fault: {f_target.ToUpper()} stuck at: {s_a_val}");
        Console.WriteLine("Test Vectors");
        bool found = false;
        for (int A = 0; A <= 1; A++)
            for (int B = 0; B <= 1; B++)
            {
                //Expected
                int expected_sum = A ^ B;
                int expected_carry = A & B;

                //Fault injection
                int A_fault = (f_target == "a") ? s_a_val : A;
                int B_fault = (f_target == "b") ? s_a_val : B;
                int fault_sum = (f_target == "sum") ? s_a_val : (A_fault^B_fault);
                int fault_carry = (f_target == "carry") ? s_a_val : (A_fault&B_fault);
                if (expected_sum != fault_sum || expected_carry != fault_carry)
                {
                    Console.WriteLine($"A={A}  B={B}  |  Expected: SUM= {expected_sum} CARRY= {expected_carry}  |  Fault: SUM={fault_sum} CARRY={fault_carry}");
                    found = true;
                }
            }
        if (found != true)
            Console.WriteLine("Fault Undetected/ No Fault");
    }
}
