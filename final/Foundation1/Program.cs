using System;

class Program
{
    static void Main(string[] args)
    {
       Video video1 = new Video();
       video1. _title = "VS Code Extension:Beyond Hello World";
       video1. _author = "Tyler Leonhardt";
       video1. _length = 08;
       

       Video video2 = new Video();
       video2. _title = "Fixing Your Layouts";
       video2. _author = "DesignCourse";
       video2. _length = (0010);
       

       Video video3 = new Video();
       video3. _title = "What I Wish I Know";
       video3. _author = "Microsft Developer";
       video3. _length =0010;
       

       Video video4 = new Video();
       video4. _title = "CSS Features";
       video4. _author = "Kevin Powell ";
       video4. _length = 0021;
       

       Comment tComment = new Comment();
       tComment. _name = "";
       tComment. _comment = "";


       tComment. _video.Add(video1);
       tComment. _video.Add(video2);
       tComment. _video.Add(video3);
       tComment. _video.Add(video4);

       tComment.Display();

    }

    }




