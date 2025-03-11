namespace ListasArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            double[] notas = new double[8]; 
            string[] arrayFrutas = {"Banana", "Maça", "Pera"};


            //string nome = "011.655.275-10";

            //Console.WriteLine(nome.Replace(".","").Replace("-",""));

            List<string> FruitList = new List<string>();

            FruitList.Add("Banana");
            FruitList.Add("Maça");
            FruitList.Add("Pera");

            // FruitList.Remove("Banana");

            //Console.WriteLine(string.Join(",", FruitList));

            // foreach (string fruta in FruitList)
            // {
            //      Console.WriteLine(fruta);
            //}

            //  FruitList.ForEach(fruta => Console.WriteLine(fruta));

            Aluno aluno1 = new Aluno("Joaozinho", 40028922,"Transforme-se","Jao@hotmail.com","11998877594");
            Aluno aluno2 = new Aluno("Mariazinha",50028923,"Transforme-se","Maria@hotmail.com","11998877594");
            Aluno aluno3 = new Aluno("Pedrin", 60028924,"Transforme-se","Pedro@hotmail.com","11998877594");

            List<Aluno>listaAlunos = new List<Aluno>();

            listaAlunos.Add(aluno1);
            listaAlunos.Add (aluno2);
            listaAlunos .Add(aluno3);


            foreach(Aluno aluno in listaAlunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome}");
                Console.WriteLine($"Nome: {aluno.Email}");
                Console.WriteLine($"Nome: {aluno.Telefone}");
                Console.WriteLine($"Nome: {aluno.Matricula}");
                Console.WriteLine($"Nome: {aluno.Curso}");

        }
    }
}
