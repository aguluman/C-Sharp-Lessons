﻿//Using the Remove() and Replace() methods
//Remove()
string data = "12345John Smith          5000  3  \n";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

//Replace()
string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);