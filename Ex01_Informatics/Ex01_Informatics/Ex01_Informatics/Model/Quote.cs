using System.Collections.Generic;

namespace Ex01_Informatics.Model
{
    class Quote
    {
        public string Content;
        public string Author;
        public string Subject;

        public override string ToString()
        {
            if (Author != null)
            {
                if (Author.Length == 0)
                    return Content + " " + Author;
                else
                    return Content;
            }
            else
                return base.ToString();
        }

        public static List<Quote> GetQuotes()
        {
            return new List<Quote>()
            {
                new Quote() { Content = "If at first you don't succeed; call it version 1.0", Author = "" , Subject = "Programming" },
                new Quote() { Content = "The Internet: where men are men, women are men, and children are FBI agents.", Author = "" , Subject = "Varia" },
                new Quote() { Content = "Some things Man was never meant to know. For everything else, there's Google.", Author = "" , Subject = "Varia" },
                new Quote() { Content = "The more I C, the less I see.", Author = "" , Subject = "Programming" },
                new Quote() { Content = "Life would be so much easier if we only had the source code.", Author = "" , Subject = "Programming" },
                new Quote() { Content = "Unix is user-friendly. It's just very selective about who its friends are.", Author = "" , Subject = "Varia" },
                new Quote() { Content = "Programming is like sex, one mistake and you have to support it for the rest of your life.", Author = "Michael Sinz" , Subject = "Programming" },
                new Quote() { Content = "There are 10 types of people in the world: those who understand binary, and those who don't.", Author = "" , Subject = "Varia" },
                new Quote() { Content = "SUPERCOMPUTER: what it sounded like before you bought it.", Author = "" , Subject = "Hardware" },
                new Quote() { Content = "I'm not anti-social; I'm just not user friendly", Author = "" , Subject = "Varia" },
                new Quote() { Content = "A printer consists of three main parts: the case, the jammed paper tray and the blinking red light", Author = "" , Subject = "Hardware" },
                new Quote() { Content = "The best accelerator available for a Mac is one that causes it to go at 9.81 m/s2.", Author = "" , Subject = "Varia" },
                new Quote() { Content = "A computer lets you make more mistakes faster than any invention in human history - with the possible exceptions of handguns and tequila", Author = "" , Subject = "Programming" },
                new Quote() { Content = "To go forward, you must backup. ", Author = "" , Subject = "Varia" },
                new Quote() { Content = "I would love to change the world, but they won't give me the source code", Author = "" , Subject = "Programming" },
                new Quote() { Content = "A Windows user spends 1/3 of his life sleeping, 1/3 working, 1/3 waiting.", Author = "" , Subject = "Windows" },
                new Quote() { Content = "My software never has bugs. It just develops random features.", Author = "" , Subject = "Programming" },
                new Quote() { Content = "Better to be a geek than an idiot.", Author = "" , Subject = "Varia" },
                new Quote() { Content = "Be nice to geeks when you're in school, you might end-up working for one when you grow-up.", Author = "" , Subject = "Varia" },
                new Quote() { Content = "Difference between a virus and windows ? Viruses rarely fail.", Author = "" , Subject = "Windows" },
                new Quote() { Content = "Evolution is God's way of issuing upgrades.", Author = "" , Subject = "Varia" },
                new Quote() { Content = "The only problem with troubleshooting is that sometimes trouble shoots back.", Author = "" , Subject = "Varia" },
                new Quote() { Content = "The box said 'Required Windows 95 or better'. So, I installed LINUX.", Author = "" , Subject = "Windows" },
                new Quote() { Content = "Computers are like air conditioners: they stop working when you open windows.", Author = "" , Subject = "Windows" },
                new Quote() { Content = "Like car accidents, most hardware problems are due to driver error.", Author = "" , Subject = "Hardware" },
                new Quote() { Content = "Real men don't use backups, they post their stuff on a public ftp server and let the rest of the world make copies.", Author = "Linus Torvalds" , Subject = "Varia" },
                new Quote() { Content = "There are 10 kinds of people in the world, those that understand trinary, those that don't, and those that confuse it with binary.", Author = "" , Subject = "Varia" },
                new Quote() { Content = "I had a fortune cookie the other day and it said: 'Outlook not so good'. I said: 'Sure, but Microsoft ships it anyway'.", Author = "" , Subject = "Windows" },
                new Quote() { Content = "Programmers are tools for converting caffeine into code.", Author = "" , Subject = "Programming" },
                new Quote() { Content = "The great thing about Object Oriented code is that it can make small, simple problems look like large, complex ones.", Author = "" , Subject = "Programming" },
                new Quote() { Content = "Hacking is like sex. You get in, you get out, and hope that you didn't leave something that can be traced back to you.", Author = "" , Subject = "Varia" }
            };
        }
    }
}
