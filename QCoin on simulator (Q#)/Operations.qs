namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Diagnostics;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;

    // "Set" fuction
    operation Set (desired: Result, q1: Qubit) : Unit {
        body (...) {
            let current = M(q1);
            if (desired != current) {X(q1);}
        }
    }

    operation Oracle (x:Qubit, y:Qubit[], input:Double[], lower_limit:Double) : Unit {
        body (...) {
            let N = Length(y);
            let N_states  = Length(input);

            for (i in 0..N-1) {H(y[i]);}
            for (i in 0..N_states-1) {
                let theta = ArcSin(input[i]-lower_limit);
                (ControlledOnInt(i,Ry))(y, (2.0*theta, x));
            }
            for (i in 0..N-1) {H(y[i]);}
        }
        adjoint auto;
    }

    operation Measurement (x : Qubit, y : Qubit[]) : Int {
        body (...) {
            let M_x = M(x);
            let M_y = ResultAsInt(MultiM(y));
            if (M_x==One && M_y==0) {return 1;}
            else {return 0;}
        }
    }

    operation Grover (x:Qubit, y:Qubit[], input:Double[], lower_limit:Double) : Unit { // (2|ψ><ψ|-1) = U(2|0><0|-1)U^-1
        body (...) {
            (ControlledOnInt(0,Z))(y, x); 
            Adjoint Oracle(x, y, input, lower_limit); // U^-1
            (ControlledOnInt(0,RAll0))(y, (2.0*ArcSin(1.0),[x]));
            Oracle(x, y, input, lower_limit); // U
        }
    }


    operation Output (F:Double, lower_limit : Double, Grover_loop : Int) : Int {
        body (...) {

            // input_oracle
            let N = 1;
            let N_states = Floor(PowD(2.0,ToDouble(N))+0.01);
            mutable input = ConstantArray (N_states, 0.0);
            for (i in 0..N_states-1) {set input[i] = F;}

            mutable M_obs = 0;
            using (x = Qubit[1]) {
                using (y = Qubit[N]) {
                    for (i in 0..Grover_loop-1) {Grover(x[0], y, input, lower_limit);} // Grover algorithm
                    set M_obs = Measurement(x[0], y); // returns |1>|0>|0> with probability f^2

                    ResetAll(y);
                }
                ResetAll(x);
            }
            return M_obs;
        }
    }

    operation First_Oracle (x:Qubit, y:Qubit[], input:Double[]) : Unit {
        body (...) {
            let N = Length(y);
            let N_states  = Length(input);

            for (i in 0..N-1) {H(y[i]);}
            for (i in 0..N_states-1) {
                let theta = ArcSin(input[i]);
                (ControlledOnInt(i,Ry))(y, (2.0*theta, x));
            }
            for (i in 0..N-1) {H(y[i]);}
        }
        adjoint auto;
    }

    operation First (F:Double) : Int {
        body (...) {
            // input_oracle
            let N = 1;
            let N_states  = Floor(PowD(2.0,ToDouble(N))+0.01);
            mutable input = ConstantArray (N_states, 0.0);
            for (i in 0..N_states-1) {set input[i] = Sqrt(F);}

            mutable M_obs = 0;
            using (x = Qubit[1]) {
                using (y = Qubit[N]) {
                    First_Oracle(x[0], y, input); // ((1-f)|0>+√f|1>)*|0>|0> + ...
                    set M_obs = ResultAsInt(MultiM(x)); // returns |1>|?>|?> with probability Σf

                    ResetAll(y);
                }
                ResetAll(x);
            }
            return M_obs;
        }
    }

}