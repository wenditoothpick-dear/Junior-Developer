// write a program that will accept two height in centimter,categorise them and find thier differences
Console.WriteLine("accept two heights of a person in centimeter , categorise them and find thier differences");
Console.WriteLine("input value for age s");
int differences = 0;
int s  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input value for age x");
int x = Convert.ToInt32(Console.ReadLine());
if(s <= 165)
{
    Console.WriteLine("the person is short");
}
else
{
   Console.WriteLine("the person is tall");
}
if(x >= 170)
{
    Console.WriteLine("the person is tall");
}
else
{
    Console.WriteLine("the person is short");
}
differences = x - s;
Console.Write($"the differences between x and s is: {differences } ");
//  8. Write a C# Sharp program to find the largest of three numbers. 
Console.WriteLine("find the largest among the three numbers.");
 Console.WriteLine("input value for t");
 int t = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("input value for k");
 int k = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("input value for g");
 int g = Convert.ToInt32(Console.ReadLine());
 
 if(t > k)
 { 
     Console.WriteLine("t is the largest among the three");
   }
     else if(k > g)
  {
   Console.WriteLine("k is the largest among the three ");
 }
  {
    if(t > g)
  {
     Console.WriteLine("t is the largest among the three.");
  } 
  else
  {
   Console.WriteLine("g is the largest among the three");
  } 
  }
// // no 9
// // Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies. 
// Console.WriteLine(" accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies. ");

// Console.Write("input value for x");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("input value for y");
// int y = Convert.ToInt32(Console.ReadLine()) 
        Console.WriteLine("Find the quadrant in which the coordinatt lies:");  
        Console.WriteLine("Input the value for o coordinate :");  
       int o = Convert.ToInt32(Console.ReadLine());  

        Console.WriteLine("Input the value for Y coordinate :");  
       int Y = Convert.ToInt32(Console.ReadLine());  

        if (o> 0 && Y > 0)  
            Console.WriteLine("The coordinate point ({0} {1}) lies in the First quadrant.", o, Y);  
        else if (o < 0 && Y > 0)  
            Console.WriteLine("The coordinate point ({0} {1}) lies in the Second quadrant.", o, Y);  
        else if (o < 0 && Y < 0)  
            Console.WriteLine("The coordinate point ({0} {1}) lies in the Third quadrant.", o, Y);  
        else if (o > 0 && Y < 0)  
            Console.WriteLine("The coordinate point ({0} {1}) lies in the Fourth quadrant.", o, Y);
        else if (o == 0 && Y == 0)  
            Console.WriteLine("The coordinate point ({0} {1}) lies at the origin.", o, Y);  
//    Write a C# Sharp program to determine the eligibility for admission to a professional course based on the following criteria: 
//  Marks in Maths >=65
// Marks in Phy >=55
// Marks in Chem>=50
// Total in all three subject >=180
// or
//  Total in Math and Subjects >=140 eligibity
// Console.WriteLine("determine the eligibility for admission to a professional course ");
//  Console.Write("Eligibility Criteria :");  
//         Console.Write("Marks in Maths >=65");
//         Console.Write("and Marks in Phy >=55");
//         Console.Write("and Marks in Chem>=50");
//         Console.Write("and Total in all three subject >=180");
//         Console.Write("or Total in Maths and Physics >=140");
// Console.WriteLine("input scores for math");
// int math = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input scores for chemistry");
// int chemistry = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input scores for physics");
// int physics = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Total marks of Maths, Physics and Chemistry : {0}", math + physics + chemistry);  
// Console.Write("Total marks of Maths and Physics : {0}", math + physics);  
// if(math >= 65)
//  if(physics >= 55)
//  if(chemistry >= 50)
// if((math + physics + chemistry ) >= 180)
// if((math + physics) >= 140)
// {
//     Console.WriteLine("the candidate is elegible for an admission");   
// }
// else 
// {
//     Console.WriteLine("the candidate is not elegible for an admission");
// }
// {
//     Console.WriteLine("the candidate is elegible for an admission");
// }
// else if ()
// {
//     Console.WriteLine("the candidate is not elegible for an admission");
// }
//     Console.WriteLine("the candidate is elegible for an admission");
// else
// {
//     Console.WriteLine("the candidate is not elegible for an admission"); 
// }
// {
//       Console.WriteLine("the candidate is  elegible for an admission"); 
// }
//  else
//       {
//         Console.WriteLine("the candidate is not elegible for an admission"); 
//       } 
//     {
//         Console.WriteLine("the candidate is elegible for an admission"); 
//     }
//       else
//       {
//         Console.WriteLine("the candidate is not elegible for an admission"); 
//        }



