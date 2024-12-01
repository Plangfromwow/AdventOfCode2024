using System.IO;
//Part 1
// var input = File.ReadAllLines("./input.txt");

// var locationList1 = new List<int>();

// var locationList2 = new List<int>();

// for (int i = 0; i < input.Length; i++)
// {
//     var inputList = input[i].Split(" ");

//     locationList1.Add(int.Parse(inputList[0]));
//     locationList2.Add(int.Parse(inputList[3]));

// }

// locationList1.Sort();
// locationList2.Sort();

// int answer = 0;

// for (int i = 0; i < locationList1.Count; i++)
// {
//     var val = locationList1[i] - locationList2[i];

//     answer += int.Abs(val);
// }

// System.Console.WriteLine(answer);

//Part 2
//This time, you'll need to figure out exactly how often each number from the left list appears in the right list.
// Calculate a total similarity score by adding up each number in the left list after 
//multiplying it by the number of times that number appears in the right list.
var input = File.ReadAllLines("./input.txt");

var locationList1 = new List<int>();

var locationList2 = new List<int>();

for (int i = 0; i < input.Length; i++)
{
    var inputList = input[i].Split(" ");

    locationList1.Add(int.Parse(inputList[0]));
    locationList2.Add(int.Parse(inputList[3]));
}

var answerList = new List<int>();

//Get amount of times each number from the right appears in the left 
foreach (var location in locationList1)
{
    int appears = 0;
    foreach (var location2 in locationList2)
    {
        if (location == location2)
        {
            appears++;
        }
    }
    //multiply by how many times it appears in the right list 
    answerList.Add(location * appears);
}

//add all these numbers together 

System.Console.WriteLine(answerList.Sum());
