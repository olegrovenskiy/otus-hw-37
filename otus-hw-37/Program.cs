using otus_hw_37;
using System.Collections.Immutable;

Console.WriteLine("Hello, World!");


var Poem = new List<string>();
Poem.Add("------------------");

Part1 Part1 = new Part1();
Part2 Part2 = new Part2();  
Part3 Part3 = new Part3();  
Part4 Part4 = new Part4();
Part5 Part5 = new Part5();
Part6 Part6 = new Part6();
Part7 Part7 = new Part7();
Part8 Part8 = new Part8();
Part9 Part9 = new Part9();


foreach (var str in Poem)
    Console.WriteLine("Start   " + str);

Part1.AddPart(Poem.ToImmutableList());
Part2.AddPart(Part1.Poem.ToImmutableList());
Part3.AddPart(Part2.Poem.ToImmutableList());
Part4.AddPart(Part3.Poem.ToImmutableList());
Part5.AddPart(Part4.Poem.ToImmutableList());
Part6.AddPart(Part5.Poem.ToImmutableList());
Part7.AddPart(Part6.Poem.ToImmutableList());
Part8.AddPart(Part7.Poem.ToImmutableList());
Part9.AddPart(Part8.Poem.ToImmutableList());



foreach (var str in Part1.Poem)
    Console.WriteLine("Part1   " + str);

foreach (var str in Part2.Poem)
    Console.WriteLine("Part2   " + str);

foreach (var str in Part3.Poem)
    Console.WriteLine("Part3   " + str);

foreach (var str in Part4.Poem)
    Console.WriteLine("Part4   " + str);

foreach (var str in Part5.Poem)
    Console.WriteLine("Part5   " + str);

foreach (var str in Part6.Poem)
    Console.WriteLine("Part6   " + str);

foreach (var str in Part7.Poem)
    Console.WriteLine("Part7   " + str);

foreach (var str in Part8.Poem)
    Console.WriteLine("Part8   " + str);

foreach (var str in Part9.Poem)
    Console.WriteLine("Part9   " + str);



Console.ReadKey();  
