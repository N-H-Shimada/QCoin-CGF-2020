using System;
using System.IO;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Solution{
    class Driver{
        static void Main(string[] args){
            using (var qsim = new QuantumSimulator()) {
                //File.WriteAllText(@"./result.txt", "");
                System.Random r = new System.Random();

                // --------------------Output--------------------
                System.Console.WriteLine($"Q     : The number of queries");
                System.Console.WriteLine($"K     : The number of k_steps");
                System.Console.WriteLine($"F     : Target mean value");
                System.Console.WriteLine($"E     : Predicted mean value");
                System.Console.WriteLine($"|F-E| : Abs error");
                System.Console.WriteLine($"A     : Counter");
                System.Console.WriteLine($"");
                System.Console.WriteLine($"Q   K      F       E     |F-E|  (A)");
                System.Console.WriteLine($"--------------------------------");
                // ----------------------------------------------


                // --------------------Variable--------------------
                int Total_Query = 400; // The number of queries
                int k_max = 3;         // The number of k-steps
                int aa_loop = 10;      // How many trials of QCoin prediction
                // ------------------------------------------------


                // -------------------Start QCoin------------------
                double F;
                double avg_error = 0.0;
                int query = 0;

                for (int aa=0;aa<aa_loop;aa++) {
                    F = r.NextDouble(); // Determine target value F randomly
                    query = 0;
                    int first_count = 0;

                    // 1st step
                    double delta = Math.Sin(Math.PI/2.0/2.0)/2.0; // Error ±δ
                    int loop = (int)Math.Floor(Total_Query/(Math.Pow(2.0,k_max)-1)); // Calculate the number of loops to reduce within Error delta
                    for (int i=0;i<loop;i++) {
                        int M_obs = (int)First.Run(qsim,F).Result; // Run on a quantum simulator (move to "Operations.qs")
                        first_count += M_obs;                      // Count how many times "QCoin" returns 1 (head).
                    }
                    double E = (double)first_count/loop; 
                    double lower_limit = E-delta;
                    if (lower_limit<0.0) lower_limit = 0.0;
                    double upper_limit = E+delta;
                    if (upper_limit>1.0) upper_limit = 1.0;
                    query += loop;


                    // 2nd and later steps
                    int k;
                    for (k=2;k<=k_max;k++) {
                        int n = (int)Math.Pow(2.0,k-2);
                        delta = Math.Sin(Math.PI/2.0/Math.Pow(2.0,k))/2.0; // Error ±δ

                        // Determine upper limit of angle
                        double upper_theta = Math.Asin(upper_limit-lower_limit);
                        double after_Grover_scale = Math.Sin(upper_theta*(2.0*n));

                        int count = 0;
                        for (int i=0;i<loop;i++) {
                            int M_obs = (int)Output.Run(qsim, F, lower_limit, n).Result; // Run on a quantum simulator (move to "Operations.qs")
                            count += M_obs;                                              // Count how many times "QCoin" returns 1 (head).
                        }
                        double prob = (double)count/loop;
                        E = Math.Pow(prob,0.5);
                        if (E>after_Grover_scale) E = after_Grover_scale;
                        double E_theta = Math.Asin(E);
                        E = Math.Sin(E_theta/(2.0*n)) + lower_limit;

                        // Determine lower and upper limit from E
                        double next_lower_limit = E-delta;
                        double next_upper_limit = E+delta;
                        if (next_lower_limit>lower_limit) lower_limit = next_lower_limit;
                        if (next_upper_limit<upper_limit) upper_limit = next_upper_limit;
 
                        query += (2*n)*loop;
                    }
                    // ----------------Output----------------
                    System.Console.WriteLine($"{query} {k_max}   {F:F5} {E:F5} {Math.Abs(E-F):F5} ({aa+1})");
                    avg_error += Math.Abs(E-F);
                    // --------------------------------------
                }

            avg_error = avg_error/aa_loop;

            // --------------------------------Output--------------------------------
            System.Console.WriteLine($"--------------------------------");
            System.Console.WriteLine($"Avg_error: {avg_error:F8}");
            System.Console.WriteLine($"");
            // -------------------------Output to result.txt-------------------------
            // File.AppendAllText(@"./result.txt", k_max.ToString());
            // File.AppendAllText(@"./result.txt", " ");
            // File.AppendAllText(@"./result.txt", query.ToString());
            // File.AppendAllText(@"./result.txt", " ");
            // File.AppendAllText(@"./result.txt", avg_error+Environment.NewLine);
            // ----------------------------------------------------------------------

            }
        }
    }
}