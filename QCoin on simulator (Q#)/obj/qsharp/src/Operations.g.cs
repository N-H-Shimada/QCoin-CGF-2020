#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Set\"},\"SourceFile\":\"/Users/NaoharuShimada/Desktop/Github%E7%94%A8/untitled%20folder/Operations.qs\",\"Position\":{\"Item1\":8,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"desired\"]},\"Type\":{\"Case\":\"Result\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":16},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q1\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":35}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Set\"},\"SourceFile\":\"/Users/NaoharuShimada/Desktop/Github%E7%94%A8/untitled%20folder/Operations.qs\",\"Position\":{\"Item1\":9,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Oracle\"},\"SourceFile\":\"/Users/NaoharuShimada/Desktop/Github%E7%94%A8/untitled%20folder/Operations.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":20}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Double\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":44}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"lower_limit\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":55},\"Item2\":{\"Line\":1,\"Column\":66}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Double\"}]},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Oracle\"},\"SourceFile\":\"/Users/NaoharuShimada/Desktop/Github%E7%94%A8/untitled%20folder/Operations.qs\",\"Position\":{\"Item1\":16,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Oracle\"},\"SourceFile\":\"/Users/NaoharuShimada/Desktop/Github%E7%94%A8/untitled%20folder/Operations.qs\",\"Position\":{\"Item1\":27,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Measurement\"},\"SourceFile\":\"/Users/NaoharuShimada/Desktop/Github%E7%94%A8/untitled%20folder/Operations.qs\",\"Position\":{\"Item1\":30,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":36}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Measurement\"},\"SourceFile\":\"/Users/NaoharuShimada/Desktop/Github%E7%94%A8/untitled%20folder/Operations.qs\",\"Position\":{\"Item1\":31,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Grover\"},\"SourceFile\":\"/Users/NaoharuShimada/Desktop/Github%E7%94%A8/untitled%20folder/Operations.qs\",\"Position\":{\"Item1\":39,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":20}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Double\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":44}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"lower_limit\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":55},\"Item2\":{\"Line\":1,\"Column\":66}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Double\"}]},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Grover\"},\"SourceFile\":\"/Users/NaoharuShimada/Desktop/Github%E7%94%A8/untitled%20folder/Operations.qs\",\"Position\":{\"Item1\":40,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Output\"},\"SourceFile\":\"/Users/NaoharuShimada/Desktop/Github%E7%94%A8/untitled%20folder/Operations.qs\",\"Position\":{\"Item1\":49,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"F\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":20}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"lower_limit\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Grover_loop\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":62}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"Double\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Output\"},\"SourceFile\":\"/Users/NaoharuShimada/Desktop/Github%E7%94%A8/untitled%20folder/Operations.qs\",\"Position\":{\"Item1\":50,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"First_Oracle\"},\"SourceFile\":\"/Users/NaoharuShimada/Desktop/Github%E7%94%A8/untitled%20folder/Operations.qs\",\"Position\":{\"Item1\":72,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Double\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":50}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Double\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"First_Oracle\"},\"SourceFile\":\"/Users/NaoharuShimada/Desktop/Github%E7%94%A8/untitled%20folder/Operations.qs\",\"Position\":{\"Item1\":73,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"First_Oracle\"},\"SourceFile\":\"/Users/NaoharuShimada/Desktop/Github%E7%94%A8/untitled%20folder/Operations.qs\",\"Position\":{\"Item1\":84,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"First\"},\"SourceFile\":\"/Users/NaoharuShimada/Desktop/Github%E7%94%A8/untitled%20folder/Operations.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"F\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":19}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Double\"},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"First\"},\"SourceFile\":\"/Users/NaoharuShimada/Desktop/Github%E7%94%A8/untitled%20folder/Operations.qs\",\"Position\":{\"Item1\":88,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
#line hidden
namespace Solution
{
    public class Set : Operation<(Result,Qubit), QVoid>, ICallable
    {
        public Set(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Qubit)>, IApplyData
        {
            public In((Result,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "Set";
        String ICallable.FullName => "Solution.Set";
        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Result,Qubit), QVoid> Body => (__in__) =>
        {
            var (desired,q1) = __in__;
#line 11 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            var current = M.Apply(q1);
#line 12 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            if ((desired != current))
            {
#line 12 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                MicrosoftQuantumPrimitiveX.Apply(q1);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Result,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result desired, Qubit q1)
        {
            return __m__.Run<Set, (Result,Qubit), QVoid>((desired, q1));
        }
    }

    public class Oracle : Adjointable<(Qubit,QArray<Qubit>,QArray<Double>,Double)>, ICallable
    {
        public Oracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,QArray<Qubit>,QArray<Double>,Double)>, IApplyData
        {
            public In((Qubit,QArray<Qubit>,QArray<Double>,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle";
        String ICallable.FullName => "Solution.Oracle";
        protected ICallable MicrosoftQuantumCanonControlledOnInt
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathArcSin
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRy
        {
            get;
            set;
        }

        public override Func<(Qubit,QArray<Qubit>,QArray<Double>,Double), QVoid> Body => (__in__) =>
        {
            var (x,y,input,lower_limit) = __in__;
#line 18 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            var N = y.Length;
#line 19 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            var N_states = input.Length;
#line 21 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line 21 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                MicrosoftQuantumPrimitiveH.Apply(y[i]);
            }

#line 22 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            foreach (var i in new Range(0L, (N_states - 1L)))
#line hidden
            {
#line 23 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                var theta = MicrosoftQuantumExtensionsMathArcSin.Apply((input[i] - lower_limit));
#line 24 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((i, MicrosoftQuantumPrimitiveRy)).Apply((y?.Copy(), ((2D * theta), x)));
            }

#line 26 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line 26 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                MicrosoftQuantumPrimitiveH.Apply(y[i]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,QArray<Qubit>,QArray<Double>,Double), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y,input,lower_limit) = __in__;
#line hidden
            var N = y.Length;
#line hidden
            var N_states = input.Length;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumPrimitiveH.Adjoint.Apply(y[i]);
            }

#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (N_states - 1L))))
#line hidden
            {
#line hidden
                var theta = MicrosoftQuantumExtensionsMathArcSin.Apply((input[i] - lower_limit));
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((i, MicrosoftQuantumPrimitiveRy)).Adjoint.Apply((y?.Copy(), ((2D * theta), x)));
            }

#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumPrimitiveH.Adjoint.Apply(y[i]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonControlledOnInt = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnInt<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumExtensionsMathArcSin = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.ArcSin));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumPrimitiveRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Ry));
        }

        public override IApplyData __dataIn((Qubit,QArray<Qubit>,QArray<Double>,Double) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit x, QArray<Qubit> y, QArray<Double> input, Double lower_limit)
        {
            return __m__.Run<Oracle, (Qubit,QArray<Qubit>,QArray<Double>,Double), QVoid>((x, y, input, lower_limit));
        }
    }

    public class Measurement : Operation<(Qubit,QArray<Qubit>), Int64>, ICallable
    {
        public Measurement(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Measurement";
        String ICallable.FullName => "Solution.Measurement";
        protected ICallable<QArray<Qubit>, QArray<Result>> MicrosoftQuantumCanonMultiM
        {
            get;
            set;
        }

        protected ICallable<QArray<Result>, Int64> MicrosoftQuantumCanonResultAsInt
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        public override Func<(Qubit,QArray<Qubit>), Int64> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line 33 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            var M_x = M.Apply(x);
#line 34 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            var M_y = MicrosoftQuantumCanonResultAsInt.Apply(MicrosoftQuantumCanonMultiM.Apply(y?.Copy()));
#line 35 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            if (((M_x == Result.One) && (M_y == 0L)))
            {
#line 35 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                return 1L;
            }
            else
            {
#line 36 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                return 0L;
            }
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonMultiM = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Result>>>(typeof(Microsoft.Quantum.Canon.MultiM));
            this.MicrosoftQuantumCanonResultAsInt = this.Factory.Get<ICallable<QArray<Result>, Int64>>(typeof(Microsoft.Quantum.Canon.ResultAsInt));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
        }

        public override IApplyData __dataIn((Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Qubit x, QArray<Qubit> y)
        {
            return __m__.Run<Measurement, (Qubit,QArray<Qubit>), Int64>((x, y));
        }
    }

    public class Grover : Operation<(Qubit,QArray<Qubit>,QArray<Double>,Double), QVoid>, ICallable
    {
        public Grover(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,QArray<Qubit>,QArray<Double>,Double)>, IApplyData
        {
            public In((Qubit,QArray<Qubit>,QArray<Double>,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Grover";
        String ICallable.FullName => "Solution.Grover";
        protected ICallable MicrosoftQuantumCanonControlledOnInt
        {
            get;
            set;
        }

        protected IUnitary<(Double,QArray<Qubit>)> MicrosoftQuantumCanonRAll0
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathArcSin
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,QArray<Qubit>,QArray<Double>,Double)> Oracle
        {
            get;
            set;
        }

        public override Func<(Qubit,QArray<Qubit>,QArray<Double>,Double), QVoid> Body => (__in__) =>
        {
            var (x,y,input,lower_limit) = __in__;
#line 42 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((0L, MicrosoftQuantumPrimitiveZ)).Apply((y?.Copy(), x));
#line 43 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            Oracle.Adjoint.Apply((x, y?.Copy(), input?.Copy(), lower_limit));
#line 44 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((0L, MicrosoftQuantumCanonRAll0)).Apply((y?.Copy(), ((2D * MicrosoftQuantumExtensionsMathArcSin.Apply(1D)), new QArray<Qubit>()
            {x})));
#line 45 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            Oracle.Apply((x, y?.Copy(), input?.Copy(), lower_limit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonControlledOnInt = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnInt<>));
            this.MicrosoftQuantumCanonRAll0 = this.Factory.Get<IUnitary<(Double,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.RAll0));
            this.MicrosoftQuantumExtensionsMathArcSin = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.ArcSin));
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
            this.Oracle = this.Factory.Get<IAdjointable<(Qubit,QArray<Qubit>,QArray<Double>,Double)>>(typeof(Oracle));
        }

        public override IApplyData __dataIn((Qubit,QArray<Qubit>,QArray<Double>,Double) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit x, QArray<Qubit> y, QArray<Double> input, Double lower_limit)
        {
            return __m__.Run<Grover, (Qubit,QArray<Qubit>,QArray<Double>,Double), QVoid>((x, y, input, lower_limit));
        }
    }

    public class Output : Operation<(Double,Double,Int64), Int64>, ICallable
    {
        public Output(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,Double,Int64)>, IApplyData
        {
            public In((Double,Double,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Output";
        String ICallable.FullName => "Solution.Output";
        protected ICallable MicrosoftQuantumCanonConstantArray
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected ICallable<Double, Int64> MicrosoftQuantumExtensionsMathFloor
        {
            get;
            set;
        }

        protected ICallable<(Double,Double), Double> MicrosoftQuantumExtensionsMathPowD
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected ICallable<(Qubit,QArray<Qubit>,QArray<Double>,Double), QVoid> Grover
        {
            get;
            set;
        }

        protected ICallable<(Qubit,QArray<Qubit>), Int64> Measurement
        {
            get;
            set;
        }

        public override Func<(Double,Double,Int64), Int64> Body => (__in__) =>
        {
            var (F,lower_limit,Grover_loop) = __in__;
#line 54 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            var N = 1L;
#line 55 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            var N_states = MicrosoftQuantumExtensionsMathFloor.Apply((MicrosoftQuantumExtensionsMathPowD.Apply((2D, MicrosoftQuantumExtensionsConvertToDouble.Apply(N))) + 0.01D));
#line 56 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            var input = MicrosoftQuantumCanonConstantArray.Apply<QArray<Double>>((N_states, 0D));
#line 57 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            foreach (var i in new Range(0L, (N_states - 1L)))
#line hidden
            {
#line 57 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                input[i] = F;
            }

#line 59 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            var M_obs = 0L;
#line hidden
            {
#line 60 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                var x = Allocate.Apply(1L);
#line hidden
                {
#line 61 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                    var y = Allocate.Apply(N);
#line 62 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                    foreach (var i in new Range(0L, (Grover_loop - 1L)))
#line hidden
                    {
#line 62 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                        Grover.Apply((x[0L], y?.Copy(), input?.Copy(), lower_limit));
                    }

#line 63 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                    M_obs = Measurement.Apply((x[0L], y?.Copy()));
#line 65 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                    ResetAll.Apply(y?.Copy());
#line hidden
                    Release.Apply(y);
                }

#line 67 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                ResetAll.Apply(x?.Copy());
#line hidden
                Release.Apply(x);
            }

#line 69 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            return M_obs;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonConstantArray = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ConstantArray<>));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.MicrosoftQuantumExtensionsMathFloor = this.Factory.Get<ICallable<Double, Int64>>(typeof(Microsoft.Quantum.Extensions.Math.Floor));
            this.MicrosoftQuantumExtensionsMathPowD = this.Factory.Get<ICallable<(Double,Double), Double>>(typeof(Microsoft.Quantum.Extensions.Math.PowD));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.Grover = this.Factory.Get<ICallable<(Qubit,QArray<Qubit>,QArray<Double>,Double), QVoid>>(typeof(Grover));
            this.Measurement = this.Factory.Get<ICallable<(Qubit,QArray<Qubit>), Int64>>(typeof(Measurement));
        }

        public override IApplyData __dataIn((Double,Double,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Double F, Double lower_limit, Int64 Grover_loop)
        {
            return __m__.Run<Output, (Double,Double,Int64), Int64>((F, lower_limit, Grover_loop));
        }
    }

    public class First_Oracle : Adjointable<(Qubit,QArray<Qubit>,QArray<Double>)>, ICallable
    {
        public First_Oracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,QArray<Qubit>,QArray<Double>)>, IApplyData
        {
            public In((Qubit,QArray<Qubit>,QArray<Double>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "First_Oracle";
        String ICallable.FullName => "Solution.First_Oracle";
        protected ICallable MicrosoftQuantumCanonControlledOnInt
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathArcSin
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRy
        {
            get;
            set;
        }

        public override Func<(Qubit,QArray<Qubit>,QArray<Double>), QVoid> Body => (__in__) =>
        {
            var (x,y,input) = __in__;
#line 75 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            var N = y.Length;
#line 76 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            var N_states = input.Length;
#line 78 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line 78 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                MicrosoftQuantumPrimitiveH.Apply(y[i]);
            }

#line 79 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            foreach (var i in new Range(0L, (N_states - 1L)))
#line hidden
            {
#line 80 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                var theta = MicrosoftQuantumExtensionsMathArcSin.Apply(input[i]);
#line 81 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((i, MicrosoftQuantumPrimitiveRy)).Apply((y?.Copy(), ((2D * theta), x)));
            }

#line 83 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line 83 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                MicrosoftQuantumPrimitiveH.Apply(y[i]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,QArray<Qubit>,QArray<Double>), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y,input) = __in__;
#line hidden
            var N = y.Length;
#line hidden
            var N_states = input.Length;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumPrimitiveH.Adjoint.Apply(y[i]);
            }

#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (N_states - 1L))))
#line hidden
            {
#line hidden
                var theta = MicrosoftQuantumExtensionsMathArcSin.Apply(input[i]);
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((i, MicrosoftQuantumPrimitiveRy)).Adjoint.Apply((y?.Copy(), ((2D * theta), x)));
            }

#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumPrimitiveH.Adjoint.Apply(y[i]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonControlledOnInt = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnInt<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumExtensionsMathArcSin = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.ArcSin));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumPrimitiveRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Ry));
        }

        public override IApplyData __dataIn((Qubit,QArray<Qubit>,QArray<Double>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit x, QArray<Qubit> y, QArray<Double> input)
        {
            return __m__.Run<First_Oracle, (Qubit,QArray<Qubit>,QArray<Double>), QVoid>((x, y, input));
        }
    }

    public class First : Operation<Double, Int64>, ICallable
    {
        public First(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "First";
        String ICallable.FullName => "Solution.First";
        protected ICallable MicrosoftQuantumCanonConstantArray
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QArray<Result>> MicrosoftQuantumCanonMultiM
        {
            get;
            set;
        }

        protected ICallable<QArray<Result>, Int64> MicrosoftQuantumCanonResultAsInt
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected ICallable<Double, Int64> MicrosoftQuantumExtensionsMathFloor
        {
            get;
            set;
        }

        protected ICallable<(Double,Double), Double> MicrosoftQuantumExtensionsMathPowD
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSqrt
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,QArray<Qubit>,QArray<Double>)> First_Oracle
        {
            get;
            set;
        }

        public override Func<Double, Int64> Body => (__in__) =>
        {
            var F = __in__;
#line 91 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            var N = 1L;
#line 92 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            var N_states = MicrosoftQuantumExtensionsMathFloor.Apply((MicrosoftQuantumExtensionsMathPowD.Apply((2D, MicrosoftQuantumExtensionsConvertToDouble.Apply(N))) + 0.01D));
#line 93 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            var input = MicrosoftQuantumCanonConstantArray.Apply<QArray<Double>>((N_states, 0D));
#line 94 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            foreach (var i in new Range(0L, (N_states - 1L)))
#line hidden
            {
#line 94 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                input[i] = MicrosoftQuantumExtensionsMathSqrt.Apply(F);
            }

#line 96 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            var M_obs = 0L;
#line hidden
            {
#line 97 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                var x = Allocate.Apply(1L);
#line hidden
                {
#line 98 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                    var y = Allocate.Apply(N);
#line 99 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                    First_Oracle.Apply((x[0L], y?.Copy(), input?.Copy()));
#line 100 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                    M_obs = MicrosoftQuantumCanonResultAsInt.Apply(MicrosoftQuantumCanonMultiM.Apply(x?.Copy()));
#line 102 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                    ResetAll.Apply(y?.Copy());
#line hidden
                    Release.Apply(y);
                }

#line 104 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
                ResetAll.Apply(x?.Copy());
#line hidden
                Release.Apply(x);
            }

#line 106 "/Users/NaoharuShimada/Desktop/Github用/untitled folder/Operations.qs"
            return M_obs;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonConstantArray = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ConstantArray<>));
            this.MicrosoftQuantumCanonMultiM = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Result>>>(typeof(Microsoft.Quantum.Canon.MultiM));
            this.MicrosoftQuantumCanonResultAsInt = this.Factory.Get<ICallable<QArray<Result>, Int64>>(typeof(Microsoft.Quantum.Canon.ResultAsInt));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.MicrosoftQuantumExtensionsMathFloor = this.Factory.Get<ICallable<Double, Int64>>(typeof(Microsoft.Quantum.Extensions.Math.Floor));
            this.MicrosoftQuantumExtensionsMathPowD = this.Factory.Get<ICallable<(Double,Double), Double>>(typeof(Microsoft.Quantum.Extensions.Math.PowD));
            this.MicrosoftQuantumExtensionsMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sqrt));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.First_Oracle = this.Factory.Get<IAdjointable<(Qubit,QArray<Qubit>,QArray<Double>)>>(typeof(First_Oracle));
        }

        public override IApplyData __dataIn(Double data) => new QTuple<Double>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Double F)
        {
            return __m__.Run<First, Double, Int64>(F);
        }
    }
}