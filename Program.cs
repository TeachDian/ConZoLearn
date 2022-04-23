using System;
using System.Diagnostics;
using System.Threading;

namespace ConZoLearn
{
    internal class Program
    {
        public static void NoAvailableContent()
        {
            Console.Title = "ConZo Learn";
            Program p = new();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(@"
                                           /
                        _,.------....___,.' ',.-.
                     ,-'          _,.--' |
                   , '         _.-'.
                  /   ,     , '                   `
                 .   /     /                     ``.
                 |  |     .                       \.\
       ____ | ___._.  | __               \ `.
     .'    `---''       ``'-.--''`  \               .  \
    .  , __               `              |   .
    `, '         ,-'.               \             | L
   , '          '    _.'                -._          /    |
  ,`-.    , '.   `--'                      >.      ,'     |   SORRY NO AVAILABLE CONTENT
 . .'\'   `-'       __,  , -.         /  `.__.-      , '
 ||:, .           , '  ;  /  / \ `        `.    .      .' /
 j |:D  \          `--'  ', '_  . .         `.__, \   , /
/ L:_ |                 .  '' :_;                `.'.'
.    '''                  ''''''                    V
 `.                                 .    `.   _, ..  `
   `, _.    ._, -'/    .. `,'   __  `
    ) \`._ ___....----''  ,'   .'  \ |   '  \  .
/   `. '`-.--''         _,' ,'     `---' |    `./  |

._  `'''--.._____..--'   ,             ' |

| .' `. `-.                /-.           /          ,
| `._.'    `,_            ;  /         ,'.

.'          /| `-.        . ,'         ,           ,
 '-.__ __ _,','    '`-..___; -...__   ,.'\ ____.___.'
 `''^--'..'   '-`-^-''--    `-^-'`.'''''''`.,^.`.--'");
            Console.Beep(600, 1000);
            Console.ReadLine();


        }//use this if there's no availbale content
        public static void NoAvailableContent2(){
            Program p = new();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(@"                       **   **
                               **************  *****
                            **$$$$  ****   $$*******
                          * $$$$$$$$$   $$* **   *$**
                         *  $    $$$$$* $* *$$$$$$$$$**
                        *  $$$$$$$$$$$$$ $$$$$$$$$**$$*
                        $$  $$$$$$$ $$$$$$$$ $$$$$$$$$$$$
                      *$ *$$$$$$$$$$$*$*$*$    *****$***
                    **$$ $$$$$$*$ **    [[[[[[[   [[[
                    **$**$$**$$$@@     [  #####  ## #
                  *$$$*****$$$$$$         ..###   ###
                  **$$$$$$$$ [[$$ ##        +++   ###
                   $$$$$$**[[  [[$$    #          ##
                     $$$***#[  #     ###      #   ##
                     $$$$$$ ##++ #+        ## ######
                     $$$$$#  ###       ##       ##
                     $$$$$#   ##            ######
                       $$$### ##      ##    #####
                         $#$ #  +##  #   ##  ## #
                         $$$$     #   +++#######                    SORRY NO AVAILABLE CONTENT
                         $$*      ##############
                         *$$# #  ++     ++++        ######
                         $$###         ++###      ##      ++
                         $# +#      #######+     +##+   ## ##
                         *#+ ##     ++###+###    +  ###+     ##
                         ## ##+#  # ++ +++++##  +  #++##       ##
                        ##+#  ##  ++##+     ###++ ##++           #
                       ##+ +   ++  +##+  +   +######## #          #
                     ");
            switch (p.iwasBackbottonhehe = Console.ReadLine()){
                case "1": MainMenu(); return;

            }
            if (p.iwasBackbottonhehe == "E"){
                MainMenu();
            }
            else
                Console.Beep(700, 800);
            
            MainMenu(); return;
        }

        private string iwasBackbottonhehe;


        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }

        }

        //MainMenu

        private static bool MainMenu(){
            Program p = new();


            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n");
            Console.WriteLine(@"              
              ██████╗ ██████╗ ███╗   ██╗███████╗ ██████╗     ██╗     ███████╗ █████╗ ██████╗ ███╗   ██╗
             ██╔════╝██╔═══██╗████╗  ██║╚══███╔╝██╔═══██╗    ██║     ██╔════╝██╔══██╗██╔══██╗████╗  ██║
             ██║     ██║   ██║██╔██╗ ██║  ███╔╝ ██║   ██║    ██║     █████╗  ███████║██████╔╝██╔██╗ ██║
             ██║     ██║   ██║██║╚██╗██║ ███╔╝  ██║   ██║    ██║     ██╔══╝  ██╔══██║██╔══██╗██║╚██╗██║
             ╚██████╗╚██████╔╝██║ ╚████║███████╗╚██████╔╝    ███████╗███████╗██║  ██║██║  ██║██║ ╚████║
              ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝ ╚═════╝     ╚══════╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝
                                                                                                      ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t\t\t\tA Console App Based E-Learning Application.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t[1] ENGLISH DICTIONARY.");
            Console.WriteLine("\t\t\t\t\t[2] MATHEMATICS ");
            Console.WriteLine("\t\t\t\t\t[3] SCIENCE");
            Console.WriteLine("\t\t\t\t\t[4] MINI GAMES");
            Console.WriteLine("\t\t\t\t\t[5] THE BRAIN TEST");
            Console.WriteLine("\t\t\t\t\t[6] COMING SOON . . .");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("\t\t\t\t\t[I]NFO.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t\t[E]XIT.");

            Console.ForegroundColor = ConsoleColor.Black;
            //Console.WriteLine("\n\n\n\n\t\t\t\t\tType 'ENGLISH' for");


            switch (p.iwasBackbottonhehe = Console.ReadLine()){
                case "1":
                    EnglishDic();
                    return true;
                case "2":
                    Mathematics();
                    return true;
                case "3":
                    Science();
                    return true;
                case "4":
                    Minigames();
                    //NoAvailableContent();
                    return true;
                case "5":
                    //Minigames();
                    //NoAvailableContent();
                    QuizList();
                    return true;
                case "6":
                    NoAvailableContent2();
                    return true;
                case "7":
                    NoAvailableContent();
                    return true;
                case "i":
                    Appinfo();
                    return true;
                case "e":
                case "E":
                    Exitapp();
                    return true;

                default:
                    MainMenu();
                    return true;
            }
        }

        private static void Exitapp(){
            Console.Beep(700, 1000);
            System.Environment.Exit(0);
        }
        private static void QuizList(){
            Program p = new();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\t\t\tTHE BRAIN TEST:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n\t\t\tSELECT SUBJECT: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\t\t\t\t[1]\tENGLISH:    ");
            Console.WriteLine("\n\t\t\t\t[2]\tMATHEMATICS:  ");
            Console.WriteLine("\n\t\t\t\t[3]\tSCIENCE:      ");


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\t\t\t[E]XIT. ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\n\t\t\t");
            switch (p.iwasBackbottonhehe = Console.ReadLine()){
                case "1": SubEnglishq(); return;
                case "2": SubMathq(); return;
                case "3": SubScieq(); return;

            }
            if (p.iwasBackbottonhehe == "e"){
                MainMenu();
            }
            if (p.iwasBackbottonhehe == "E"){
                MainMenu();
            }
            else
                Console.Beep(700, 800);

            QuizList(); return;

            void SubEnglishq(){
                Program p = new();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\n\t\tENGLISH:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\n\t\t\tSELECT DIFFICULTY: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\t\t\t[1]\tEASY:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\t[2]\tNORMAL:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t\t[3]\tHARD:");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t[4]\tINSANE:");
                Console.WriteLine("\n\n\t\t\t[E]XIT.");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("\n\t\t\t ");

                switch (p.iwasBackbottonhehe = Console.ReadLine()){
                    case "1": EngQuizListEasy(); return;
                    case "2": EngQuizListNormal(); return;
                    case "3": EngQuizListHard(); return;
                    case "4": EngQuizListInsane(); return;
                }
                if (p.iwasBackbottonhehe == "e"){
                    QuizList();
                }
                if (p.iwasBackbottonhehe == "E"){
                    QuizList();
                }
                else
                    Console.Beep(700, 800);
                
                SubEnglishq(); return;
                void EngQuizListEasy()
                {
                    var TotalScore = 0;
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\n\t\tENGLISH:");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\n\t\t\tEASY: TYPE \"TRUE\" IF THE STATEMENT IS TRUE AND \"FALSE\" \n\t\t\tIF THE STATEMENT IS WRONG ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\t\t\t1.\tA RIVER is bigger than a STREAM: ");
                    var entry = Console.ReadLine();
                    if (entry.ToUpper() == "TRUE") { TotalScore += 1; }
                    Console.Write("\n\t\t\t2.\tThere are one thousand years in a CENTURY: ");
                    var entry1 = Console.ReadLine();
                    if (entry1.ToUpper() == "FALSE") { TotalScore += 1; }
                    Console.Write("\n\t\t\t3.\tFOUNDED is the past tense of FOUND: ");
                    var entry2 = Console.ReadLine();
                    if (entry2.ToUpper() == "TRUE") { TotalScore += 1; }
                    Console.Write("\n\t\t\t4.\tANSWER can be used as a noun and a verb: ");
                    var entry3 = Console.ReadLine();
                    if (entry3.ToUpper() == "TRUE") { TotalScore += 1; }
                    Console.Write("\n\t\t\t5.\tSCARLET is a brilliant red colour: ");
                    var entry4 = Console.ReadLine();
                    if (entry4.ToUpper() == "TRUE") { TotalScore += 1; }
                    Console.Write("\n\t\t\t6.\tUSED TO DOING and USED TO DO mean the same thing: ");
                    var entry5 = Console.ReadLine();
                    if (entry5.ToUpper() == "FALSE") { TotalScore += 1; }
                    Console.Write("\n\t\t\t7.\tYou can use IMPROVE as a noun and as a verb: ");
                    var entry6 = Console.ReadLine();
                    if (entry6.ToUpper() == "FALSE") { TotalScore += 1; }
                    Console.Write("\n\t\t\t8.\tDOZEN is equivalent to 20: ");
                    var entry7 = Console.ReadLine();
                    if (entry7.ToUpper() == "FALSE") { TotalScore += 1; }
                    Console.Write("\n\t\t\t9.\tThe past tense of FIND is FOUND: ");
                    var entry8 = Console.ReadLine();
                    if (entry8.ToUpper() == "TRUE") { TotalScore += 1; }
                    Console.Write("\n\t\t\t10.\tEQUIVALENT TO is (more or less) the same as EQUAL TO.: ");
                    var entry9 = Console.ReadLine();
                    if (entry9.ToUpper() == "TRUE") { TotalScore += 1; }


                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n\t\t\tTOTAL SCORE:\t" + TotalScore + " ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\t\t\tPRESS ANY KEY TO EXIT."); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\t[R]ESET");

                    switch (p.iwasBackbottonhehe = Console.ReadLine()){
                        case "r": EngQuizListEasy(); return;
                    }
                    if (p.iwasBackbottonhehe == "R"){
                        EngQuizListEasy();
                    }
                    else{
                        Console.Beep(700, 800);
                    }
                    SubEnglishq(); return;
                } //done
                void EngQuizListNormal()
                {
                    var TotalScore = 0;
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\n\t\tENGLISH:");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\n\t\t\tNORMAL: TYPE \"ACTIVE\" IF THE STATEMENT IS A ACTIVE STATEMENT \n\t\t\tAND \"PASSIVE\" IF IT'S A PASSIVE STATEMENT ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\t\t\t1.\tI ate a piece of chocolate cake: ");
                    var entry = Console.ReadLine();
                    if (entry.ToUpper() == "ACTIVE") { TotalScore += 1; }
                    Console.Write("\n\t\t\t2.\tThe librarian read the book to the students: ");
                    var entry1 = Console.ReadLine();
                    if (entry1.ToUpper() == "ACTIVE") { TotalScore += 1; }
                    Console.Write("\n\t\t\t3.\tThe money was stolen: ");
                    var entry2 = Console.ReadLine();
                    if (entry2.ToUpper() == "PASSIVE") { TotalScore += 1; }
                    Console.Write("\n\t\t\t4.\tThey are paid on Fridays: ");
                    var entry3 = Console.ReadLine();
                    if (entry3.ToUpper() == "PASSIVE") { TotalScore += 1; }
                    Console.Write("\n\t\t\t5.\tThe movie is being made in Hollywood: ");
                    var entry4 = Console.ReadLine();
                    if (entry4.ToUpper() == "PASSIVE") { TotalScore += 1; }
                    Console.Write("\n\t\t\t6.\tI washed my car three weeks ago: ");
                    var entry5 = Console.ReadLine();
                    if (entry5.ToUpper() == "ACTIVE") { TotalScore += 1; }
                    Console.Write("\n\t\t\t7.\tHis hair was cut by a professional: ");
                    var entry6 = Console.ReadLine();
                    if (entry6.ToUpper() == "PASSIVE") { TotalScore += 1; }
                    Console.Write("\n\t\t\t8.\tI will introduce you to my boss this week: ");
                    var entry7 = Console.ReadLine();
                    if (entry7.ToUpper() == "ACTIVE") { TotalScore += 1; }
                    Console.Write("\n\t\t\t9.\tIt would have been fixed at the weekend: ");
                    var entry8 = Console.ReadLine();
                    if (entry8.ToUpper() == "PASSIVE") { TotalScore += 1; }
                    Console.Write("\n\t\t\t10.\tThe national anthem is being sung by Jason this time: ");
                    var entry9 = Console.ReadLine();
                    if (entry9.ToUpper() == "PASSIVE") { TotalScore += 1; }


                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n\t\t\tTOTAL SCORE:\t" + TotalScore + " ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\t\t\tPRESS ANY KEY TO EXIT."); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\t[R]ESET");

                    switch (p.iwasBackbottonhehe = Console.ReadLine()){
                        case "r": EngQuizListNormal(); return;
                    }
                    if (p.iwasBackbottonhehe == "R"){
                        EngQuizListNormal();
                    }
                    else
                        Console.Beep(700, 800);                    
                    SubEnglishq(); return;

                } //DONE
                void EngQuizListHard()
                {
                    var TotalScore = 0;
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\n\t\tENGLISH:");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\n\t\t\tHARD: TYPE \"PREPOSITION\" \"ADJECTIVE\" \"NOUN\" \"PRONOUN\" \"CONJUCTION\" \n\t\t\"ADVERB\" \"VERB\" \"INTERJECTION\" PART OF SPEECH");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\t\t\t1.\tI bought a beautiful dress at the mall: ");
                    var entry = Console.ReadLine();
                    if (entry.ToUpper() == "ADJECTIVE") { TotalScore += 1; }
                    Console.Write("\n\t\t\t2.\tWhat did she ask you to do?: ");
                    var entry1 = Console.ReadLine();
                    if (entry1.ToUpper() == "PRONOUN") { TotalScore += 1; }
                    Console.Write("\n\t\t\t3.\tI left my shoes under the kitchen table: ");
                    var entry2 = Console.ReadLine();
                    if (entry2.ToUpper() == "PREPOSITION") { TotalScore += 1; }
                    Console.Write("\n\t\t\t4.\tIf we finish our work quickly we can go to the movies: ");
                    var entry3 = Console.ReadLine();
                    if (entry3.ToUpper() == "ADVERB") { TotalScore += 1; }
                    Console.Write("\n\t\t\t5.\tOn Saturdays I work from nine to five: ");
                    var entry4 = Console.ReadLine();
                    if (entry4.ToUpper() == "VERB") { TotalScore += 1; }
                    Console.Write("\n\t\t\t6.\tI want to go to a university in the United States: ");
                    var entry5 = Console.ReadLine();
                    if (entry5.ToUpper() == "NOUN") { TotalScore += 1; }
                    Console.Write("\n\t\t\t7.\tI'm sure I've met your girlfriend before: ");
                    var entry6 = Console.ReadLine();
                    if (entry6.ToUpper() == "VERB") { TotalScore += 1; }
                    Console.Write("\n\t\t\t8.\tWell, I don't think I'll be home before 6: ");
                    var entry7 = Console.ReadLine();
                    if (entry7.ToUpper() == "INTERJECTION") { TotalScore += 1; }
                    Console.Write("\n\t\t\t9.\tAndy knocked on the door but nobody answered: ");
                    var entry8 = Console.ReadLine();
                    if (entry8.ToUpper() == "CONJUNCTION") { TotalScore += 1; }
                    Console.Write("\n\t\t\t10.\tAfter lunch let's go out for a coffee: ");
                    var entry9 = Console.ReadLine();
                    if (entry9.ToUpper() == "PREPOSITION") { TotalScore += 1; }


                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n\t\t\tTOTAL SCORE:\t" + TotalScore + " ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\t\t\tPRESS ANY KEY TO EXIT."); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\t[R]ESET");

                    switch (p.iwasBackbottonhehe = Console.ReadLine())
                    {
                        case "r": EngQuizListHard(); return;
                    }
                    if (p.iwasBackbottonhehe == "R")
                    {
                        EngQuizListHard();
                    }
                    else
                    {
                        Console.Beep(700, 800);
                    }
                    SubEnglishq(); return;

                } //Done
                void EngQuizListInsane()
                {
                    var TotalScore = 0;
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\n\t\tENGLISH:");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\n\t\t\tINSANE: UPPER CASE ANSWER ONLY");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.Write(@"                    
                 1. The county cleared this 'PATH AND PAVED' it with packed gravel, so they would 
                    have a peaceful place to hike and bike.

                    Which of the following alternatives to the highlighted portion would NOT 
                    be acceptable?

                       [A] path, paving
                       [B] path and then paved
                       [C] path before paving
                       [D] path paved
                       : ");
                    var entry = Console.ReadLine();
                    if (entry.ToUpper() == "ADJECTIVE") { TotalScore += 1; }

                    Console.Write(@"
                 2. The first train took twenty-six minutes to complete the route, which ran from 
                    City Hall to West 145th Street 'IN UNDER A HALF AN HOUR'.

                       [A] NO CHANGE
                       [B] in the completion of its route.
                       [C] in twenty-six minutes.
                       [D] DELETE the underlined portion and end the sentence with a period.
                       : ");
                    var entry1 = Console.ReadLine();
                    if (entry1.ToUpper() == "D") { TotalScore += 1; }

                    Console.Write(@"
                 3. The fresco is a dynamic work 'BECAUSE', by capturing the energy, humanity, 
                    and collective achievement of the Detroit workers, celebrates all working 
                    men and women.

                       [A] NO CHANGE
                       [B] that,
                       [C] while,
                       [D] that was,
                       : ");
                    var entry2 = Console.ReadLine();
                    if (entry2.ToUpper() == "B") { TotalScore += 1; }

                    Console.Write(@"
                 4. We talked just as easily as we had in the past, when we would sit in the 
                    field behind Joan’s house atop the rabbit hutch and discuss our friends 
                    and our hopes for the future.

                       [A] NO CHANGE
                       [B] in the field atop the rabbit hutch behind Joan’s house
                       [C] atop the rabbit hutch in the field behind Joan’s house
                       [D] behind Joan’s house in the field atop the rabbit hutch
                       : ");
                    var entry3 = Console.ReadLine();
                    if (entry3.ToUpper() == "C") { TotalScore += 1; }

                    Console.Write(@"
                 5. In some agricultural parts of Japan, for instance, these three stars are 
                    commonly referred to as Karasuki and represent a three-pronged plow.

                    Given that all the choices are true, which one provides a detail that 
                    has the most direct connection to the information that follows in this 
                    sentence?

                       [A] NO CHANGE
                       [B] distant
                       [C] populated
                       [D] historic   
                       : ");
                    var entry4 = Console.ReadLine();
                    if (entry4.ToUpper() == "A") { TotalScore += 1; }

                    Console.Write(@"
                 6. Unbricking a kiln after a firing is like a person uncovering buried 
                    treasure.

                       [A] NO CHANGE
                       [B] someone
                       [C] a potter
                       [D] OMIT the underlined portion
                       : ");
                    var entry5 = Console.ReadLine();
                    if (entry5.ToUpper() == "D") { TotalScore += 1; }

                    Console.Write(@"
                 7. [1] Our son has started playing organized T-ball, a beginner’s version 
                    of baseball. [2] “Organized” is what parents call it, anyway. [3] Joe 
                    is seven, living in those two or three years when children can manage 
                    to throw a baseball a few feet but when what they’re really interested 
                    in are things closer at hand: bugs, butterflies, dirt (if they’re in 
                    the infield), grass (if they’re in the outfield). [4] Children of that 
                    age still think nothing of doing little dances in the outfield, often 
                    with their backs to home plate and, consequently, the batter. [5] It’s 
                    not as if the outfielders’ positions matter much, though—the ball 
                    never gets hit hard enough to reach there.

                    The writer wishes to add the following sentence in order to emphasize 
                    the uncertainty already expressed about an idea in the paragraph:

                    I still have doubts.

                    The new sentence would best amplify and be placed after Sentence:

                       [A] 1.
                       [B] 2.
                       [C] 3.
                       [D] 4.
                       : ");
                    var entry6 = Console.ReadLine();
                    if (entry6.ToUpper() == "B") { TotalScore += 1; }

                    Console.Write(@"
                 8. Banneker lived and worked on the family farm. After his father died 
                    in 1759, Banneker took over the responsibility of the farm and the care 
                    of his mother and younger sisters. In addition, he pursued scientific 
                    studies and taught himself to play the flute and violin.

                    If the writer were to delete the last part of the preceding sentence 
                    (ending the sentence with a period after the word studies), the 
                    paragraph would primarily lose:

                       [A] support for the essay’s point about Banneker’s love of learning.
                       [B] a direct link to the previous paragraph.
                       [C] a humorous description of Banneker’s other interests.
                       [D] an extensive digression about music
                       : ");
                    var entry7 = Console.ReadLine();
                    if (entry7.ToUpper() == "A") { TotalScore += 1; }

                    Console.Write(@"
                 9. The two principal types of kayaks are: the easily maneuverable 
                    white-water kayak and the largest sea kayak.

                       [A] NO CHANGE
                       [B] very biggest
                       [C] more large
                       [D] larger
                       : ");
                    var entry8 = Console.ReadLine();
                    if (entry8.ToUpper() == "D") { TotalScore += 1; }

                    Console.Write(@"
                10. Radioactive pools of toxic waste are okay for others to live 
                    in; even acid cannot kill them.

                       [A] NO CHANGE
                       [B] are all right for others to live in;
                       [C] are home to still others;
                       [D] suit others to a tee;
                       : ");
                    var entry9 = Console.ReadLine();
                    if (entry9.ToUpper() == "C") { TotalScore += 1; }

                    Console.Write(@"
                11. As the dancers step to the music, they were also stepping in 
                    time to a sound that embodies their unique history and suggests 
                    the influence of outside cultures on their music.

                       [A] NO CHANGE
                       [B] are also stepping
                       [C] have also stepped
                       [D] will also step
                       : ");
                    var entry10 = Console.ReadLine();
                    if (entry10.ToUpper() == "B") { TotalScore += 1; }

                    Console.Write(@"
                12. To add to the confusion, every New Year’s Day a person according 
                    to this Korean counting system, becomes a year older, regardless 
                    of his or her actual birthday.

                       [A] NO CHANGE
                       [B] person,
                       [C] person;
                       [D] person who,
                       : ");
                    var entry11 = Console.ReadLine();
                    if (entry11.ToUpper() == "B") { TotalScore += 1; }
                    //question 14
                    Console.Write(@"
                13. Some sixty years later, an elderly Frances Griffiths publicly 
                    admitted that her and her cousin had staged the photographs 
                    as a practical joke.

                       [A] NO CHANGE
                       [B] her cousin and herself
                       [C] she and her cousin
                       [D] her cousin and her
                       : ");
                    var entry12 = Console.ReadLine();
                    if (entry12.ToUpper() == "C") { TotalScore += 1; }

                    Console.Write(@"
                14. One significant aspect of this relationship was: that Susan 
                    was perhaps the only reader of Emily’s poems-in-progress.

                       [A] NO CHANGE
                       [B] was that Susan
                       [C] was, that Susan
                       [D] was that Susan,
                       : ");
                    var entry13 = Console.ReadLine();
                    if (entry13.ToUpper() == "B") { TotalScore += 1; }

                    Console.Write(@"
                15. The Navajo language is complex, with a structure and sounds that 
                    makes them unintelligible to anyone without extensive exposure 
                    to it.

                       [A] NO CHANGE
                       [B] makes it
                       [C] make it
                       [D] make them
                       : ");
                    var entry14 = Console.ReadLine();
                    if (entry14.ToUpper() == "C") { TotalScore += 1; }


                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n\t\t\tTOTAL SCORE:\t" + TotalScore + " ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\t\t\tPRESS ANY KEY TO EXIT."); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\t[R]ESET");

                    switch (p.iwasBackbottonhehe = Console.ReadLine())
                    {
                        case "r": EngQuizListInsane(); return;
                    }
                    if (p.iwasBackbottonhehe == "R")
                    {
                        EngQuizListInsane();
                    }
                    else
                    {
                        Console.Beep(700, 800);
                    }
                    SubEnglishq(); return;


                } // DONE

            }
            void SubMathq()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\n\t\tMATHEMATICS:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\n\t\t\tSELECT DIFFICULTY: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\t\t\t[1]\tEASY:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\t[2]\tNORMAL:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t\t[3]\tHARD:");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t[4]\tINSANE:");
                Console.WriteLine("\n\n\t\t\t[E]XIT.");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("\n\t\t\t ");

                switch (p.iwasBackbottonhehe = Console.ReadLine())
                {
                    case "1": MathQuizListEasy(); return;
                    case "2": MathQuizListNormal(); return;
                    case "3": MathQuizListHard(); return;
                    case "4": MathQuizListInsane(); return;
                }
                if (p.iwasBackbottonhehe == "e")
                {
                    QuizList();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    QuizList();
                }
                else
                {
                    Console.Beep(700, 800);
                }
                SubMathq(); return;

                void MathQuizListEasy()
                {
                    var TotalScore = 0;
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\n\t\tMATHEMATICS:");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\t\t\tEASY: FUN MATH QUESTIONS");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(@"
                 1. If 1=3
                    2=3
                    3=5
                    4=4
                    5=4
                    Then, 6=?
                    : ");
                    var entry = Console.ReadLine();
                    if (entry.ToUpper() == "3") { TotalScore += 1; }
                    Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n                  ANSWER: "); Console.ForegroundColor = ConsoleColor.White; Console.Write("is 3, because ‘six’ has three letters");
                    Console.ReadLine();
                    Console.WriteLine("\n");
                    Console.Write(@"
                 2. Replace the question mark in the above problem with the 
                    appropriate number.
                    9-----1-----5
                    | \   |   / |
                    |   \ | /   |
                    4-----8-----3
                    |   / | \   |
                    | /   |   \ |
                    2-----?-----7
                    : ");
                    var entry1 = Console.ReadLine();
                    if (entry1.ToUpper() == "6") { TotalScore += 1; }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    Console.WriteLine("\n");

                    Console.Write(@"
                 3. There are 49 dogs signed up for a dog show. There are 
                    36 more small dogs than large dogs. How many small dogs 
                    have signed up to compete? 
                    
                    This question comes directly from a second grader's math
                    homework.
                    
                    : ");
                    var entry2 = Console.ReadLine();
                    if (entry2.ToUpper() == "42.5") { TotalScore += 1; }
                    Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n                  ANSWER: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(@"
                    To figure out how many small dogs are competing, you have 
                    to subtract 36 from 49 and then divide that answer, 13 by 
                    2, to get 6.5 dogs, or the number of big dogs competing. 
                    But you’re not done yet! You then have to add 6.5 to 36 to 
                    get the number of small dogs competing, which is 42.5. Of 
                    course, it’s not actually possible for half a dog to 
                    compete in a dog show, but for the sake of this math problem 
                    let’s assume that it is.
");
                    Console.ReadLine();
                    Console.WriteLine("\n");

                    Console.Write(@"
                 4. Some sixty years later, an elderly Frances Griffiths publicly admitted 
                    that her and her cousin had staged the photographs as a practical joke.

                    [A] NO CHANGE
                    [B] her cousin and herself
                    [C] she and her cousin
                    [D] her cousin and her
                    : ");
                    var entry3 = Console.ReadLine();
                    if (entry3.ToUpper() == "c") { TotalScore += 1; }
                    if (entry3.ToUpper() == "C") { TotalScore += 1; }
                    Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n                  ANSWER: "); Console.ForegroundColor = ConsoleColor.White; Console.Write("?");
                    Console.ReadLine();
                    Console.WriteLine("\n");

                    Console.Write(@"
                 5. Radioactive pools of toxic waste are okay for others to live in; even 
                    acid cannot kill them.

                    [A] NO CHANGE
                    [B] are all right for others to live in;
                    [C] are home to still others;
                    [D] suit others to a tee;
                    : ");
                    var entry4 = Console.ReadLine();
                    if (entry4.ToUpper() == "c") { TotalScore += 1; }
                    if (entry4.ToUpper() == "C") { TotalScore += 1; }
                    Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n                  ANSWER: "); Console.ForegroundColor = ConsoleColor.White; Console.Write("?");
                    Console.ReadLine();
                    Console.WriteLine("\n");


                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n\t\t\tTOTAL SCORE:\t" + TotalScore + " ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\t\t\tPRESS ANY KEY TO EXIT."); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\t[R]ESET");

                    switch (p.iwasBackbottonhehe = Console.ReadLine())
                    {
                        case "r": MathQuizListEasy(); return;
                    }
                    if (p.iwasBackbottonhehe == "R")
                    {
                        MathQuizListEasy();
                    }
                    else
                    {
                        Console.Beep(700, 800);
                    }
                    SubMathq(); return;
                }

                void MathQuizListNormal()
                {
                    var TotalScore = 0;
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\n\t\tMATHEMATICS:");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\n\t\t\tNORMAL: ");

                    var entry9 = Console.ReadLine();
                    if (entry9.ToUpper() == "TRUE") { TotalScore += 1; }


                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n\t\t\tTOTAL SCORE:\t" + TotalScore + " ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\t\t\tPRESS ANY KEY TO EXIT."); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\t[R]ESET");

                    switch (p.iwasBackbottonhehe = Console.ReadLine())
                    {
                        case "r": MathQuizListNormal(); return;
                    }
                    if (p.iwasBackbottonhehe == "R")
                    {
                        MathQuizListNormal();
                    }
                    else
                    {
                        Console.Beep(700, 800);
                    }
                    SubMathq(); return;
                }

                void MathQuizListHard()
                {
                    var TotalScore = 0;
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\n\t\tMATHEMATICS:");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\n\t\t\tHARD: ");

                    var entry9 = Console.ReadLine();
                    if (entry9.ToUpper() == "TRUE") { TotalScore += 1; }


                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n\t\t\tTOTAL SCORE:\t" + TotalScore + " ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\t\t\tPRESS ANY KEY TO EXIT."); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\t[R]ESET");

                    switch (p.iwasBackbottonhehe = Console.ReadLine())
                    {
                        case "r": MathQuizListHard(); return;
                    }
                    if (p.iwasBackbottonhehe == "R")
                    {
                        MathQuizListHard();
                    }
                    else
                    {
                        Console.Beep(700, 800);
                    }
                    SubMathq(); return;
                }

                void MathQuizListInsane()
                {
                    var TotalScore = 0;
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\n\t\tMATHEMATICS:");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\n\t\t\tINSANE: ");

                    var entry9 = Console.ReadLine();
                    if (entry9.ToUpper() == "TRUE") { TotalScore += 1; }


                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n\t\t\tTOTAL SCORE:\t" + TotalScore + " ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\t\t\tPRESS ANY KEY TO EXIT."); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\t[R]ESET");

                    switch (p.iwasBackbottonhehe = Console.ReadLine())
                    {
                        case "r": MathQuizListInsane(); return;
                    }
                    if (p.iwasBackbottonhehe == "R")
                    {
                        MathQuizListInsane();
                    }
                    else
                    {
                        Console.Beep(700, 800);
                    }
                    SubMathq(); return;
                }

            }
            void SubScieq()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\n\t\tSCIENCE:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\n\t\t\tSELECT DIFFICULTY: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\t\t\t[1]\tEASY:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\t[2]\tNORMAL:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t\t[3]\tHARD:");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t[4]\tINSANE:");
                Console.WriteLine("\n\n\t\t\t[E]XIT.");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("\n\t\t\t ");

                switch (p.iwasBackbottonhehe = Console.ReadLine())
                {
                    case "1": SciQuizListEasy(); return;
                    case "2": SciQuizListNormal(); return;
                    case "3": SciQuizListHard(); return;
                    case "4": SciQuizListInsane(); return;
                }
                if (p.iwasBackbottonhehe == "e")
                {
                    QuizList();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    QuizList();
                }
                else
                {
                    Console.Beep(700, 800);
                }
                SubScieq(); return;
                void SciQNoAvailableContent()
                {
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(@"     
                                                /
                             _,.------....___,.' ',.-.
                          ,-'          _,.--' |
                        , '         _.-'.
                       /   ,     , '                   `
                      .   /     /                     ``.
                      |  |     .                       \.\
            ____ | ___._.  | __               \ `.
          .'    `---''       ``'-.--''`  \               .  \
         .  , __               `              |   .
         `, '         ,-'.               \             | L
        , '          '    _.'                -._          /    |
       ,`-.    , '.   `--'                      >.      ,'     |   QUIZ IS BEING CREATED:)
      . .'\'   `-'       __,  , -.         /  `.__.-      , '
      ||:, .           , '  ;  /  / \ `        `.    .      .' /
      j |:D  \          `--'  ', '_  . .         `.__, \   , /
     / L:_ |                 .  '' :_;                `.'.'
     .    '''                  ''''''                    V
      `.                                 .    `.   _, ..  `
        `, _.    ._, -'/    .. `,'   __  `
         ) \`._ ___....----''  ,'   .'  \ |   '  \  .
     /   `. '`-.--''         _,' ,'     `---' |    `./  |
     
     ._  `'''--.._____..--'   ,             ' |
     
     | .' `. `-.                /-.           /          ,
     | `._.'    `,_            ;  /         ,'.
     
     .'          /| `-.        . ,'         ,           ,
      '-.__ __ _,','    '`-..___; -...__   ,.'\ ____.___.'
      `''^--'..'   '-`-^-''--    `-^-'`.'''''''`.,^.`.--'");
                    switch (p.iwasBackbottonhehe = Console.ReadLine())
                    {
                        case "e": SubScieq(); return;
                    }
                    if (p.iwasBackbottonhehe == "E")
                    {
                        SubScieq();
                    }
                    else
                    {
                        Console.Beep(700, 800);
                    }
                    SubScieq(); return;


                }//use this if there's no availbale
                void SciQuizListEasy()
                {
                    SciQNoAvailableContent();
                }
                void SciQuizListNormal()
                {
                    SciQNoAvailableContent();
                }
                void SciQuizListHard()
                {
                    SciQNoAvailableContent();
                }
                void SciQuizListInsane()
                {
                    SciQNoAvailableContent();
                }

            }

        } //In Progress-

        private static void Appinfo()
        {
            Program p = new();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("\t\t\t\t\t\t[1] How to Use the app.");
            Console.WriteLine("\t\t\t\t\t\t[2] Info about the app.");
            Console.WriteLine("\t\t\t\t\t\t[3] Credentials.");
            Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t\t\t[E]XIT");

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t\t\t\tVersion: 1.0.1.0");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\n\t\t\t\t\t\t");

            //Console.WriteLine("\t\t\t\tConZoLearn is a Console App App-Based E-Learning For all Age, and Subjects Available.");
            //Console.WriteLine("\t\t\t\tConZoLearn is in it's Beta Testing Phase so Buggs and Error is Expected.");
            switch (p.iwasBackbottonhehe = Console.ReadLine())
            {
                case "1":
                    Howtouse();
                    return;
                case "2":
                    Infoapp();
                    return;
                case "3":
                    Crdt();
                    return;
            }
            if (p.iwasBackbottonhehe == "e")
            {
                MainMenu();
            }
            if (p.iwasBackbottonhehe == "E")
            {
                MainMenu();
            }
            else
            {
                ;
            }
            Appinfo(); return;


            //users manual
            //
            static void Howtouse()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\n\n\n\t\t\t\t\t\t\t\tJust Follow the Instructions ;)");
                Console.WriteLine("\t\t\t\t\t\t\t\tAlways Use [E] when you're going to exit a Void.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t[E]XIT");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n\t\t\t\t\t\t\t\t");

                switch (p.iwasBackbottonhehe = Console.ReadLine())
                {
                    case "e":
                        Appinfo();
                        return;
                }
                if (p.iwasBackbottonhehe == "e")
                {
                    Appinfo();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    Appinfo();
                }
                else
                {
                    ;
                }
                Howtouse(); return;


            }

            //Info about the app
            //
            static void Infoapp()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("\n\n\n\n\t\t\t\t\t\tThe Tic Tac Toe Game was inspired(Copy with revised code) from:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t\t\t\thttps://www.c-sharpcorner.com/UploadFile/75a48f/tic-t\n\t\t\t\t\t\tac-toe-game-in-C-Sharp/");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\t\t\t\t\t\tThe Snake Game was inspired(Copy with revised code) from:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t\t\t\thttps://codereview.stackexchange.com/questions/210835\n\t\t\t\t\t\t/console-snake-game-in-c");
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t[E]XIT MENU");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(" ");

                switch (p.iwasBackbottonhehe = Console.ReadLine())
                {
                    case "e":
                        Appinfo();
                        return;
                }
                if (p.iwasBackbottonhehe == "e")
                {
                    Appinfo();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    Appinfo();
                }
                else
                {
                    ;
                }
                Infoapp(); return;
            }

            //Creators and so on
            //
            static void Crdt()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("\t\t\t\t\t\t\t\t\tPROJECT BY: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("");
                Console.WriteLine("\t\t\t\t\t\t\t\t\tJOHN PHILIP G. SABINET");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\t\t\t\t\t\t\t\t\tTEAM LEADER / LEAD PROGRAMMER");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\t\t\t\t\t\t\tLORD NINO L. DELA PENA");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\t\t\t\t\t\t\t\t\tSUPPORTING PROGRAMMER");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\t\t\t\t\t\t\tWALEED U. JUANILLO");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\t\t\t\t\t\t\t\t\tDOCUMENTER / SUPPORTING PROGRAMMER");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("\t\t\t\t\t\t\t\t\tPOWERED BY: ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\t\t\t\t\t\t\t\t\tVISUAL STUDIO 2022");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t[E]XIT MENU");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(" ");

                switch (p.iwasBackbottonhehe = Console.ReadLine())
                {
                    case "e":
                        Appinfo();
                        return;
                }
                if (p.iwasBackbottonhehe == "e")
                {
                    Appinfo();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    Appinfo();
                }
                else
                {
                    ;
                }
                Crdt(); return;
            }
        } //Finished

        // Math
        private static void Mathematics()
        {
            Program p = new();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n");
            Console.Write(@"          
          ███╗   ███╗ █████╗ ████████╗██╗  ██╗███████╗███╗   ███╗ █████╗ ████████╗██╗ ██████╗███████╗
          ████╗ ████║██╔══██╗╚══██╔══╝██║  ██║██╔════╝████╗ ████║██╔══██╗╚══██╔══╝██║██╔════╝██╔════╝
          ██╔████╔██║███████║   ██║   ███████║█████╗  ██╔████╔██║███████║   ██║   ██║██║     ███████╗
          ██║╚██╔╝██║██╔══██║   ██║   ██╔══██║██╔══╝  ██║╚██╔╝██║██╔══██║   ██║   ██║██║     ╚════██║
          ██║ ╚═╝ ██║██║  ██║   ██║   ██║  ██║███████╗██║ ╚═╝ ██║██║  ██║   ██║   ██║╚██████╗███████║
          ╚═╝     ╚═╝╚═╝  ╚═╝   ╚═╝   ╚═╝  ╚═╝╚══════╝╚═╝     ╚═╝╚═╝  ╚═╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝                                                                                          
          ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\t\t[1]\tALGEBRA:                            ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t[2]\tARITHMETIC:                         ");
            Console.WriteLine("\t\t[3]\tCALCULUS:                           ");
            Console.WriteLine("\t\t[4]\tGEOMETRY:                           ");
            Console.WriteLine("\t\t[5]\tPROBABILITY AND STATISTICS:         ");
            Console.WriteLine("\t\t[6]\tNUMBER SYSTEM:                      ");
            Console.WriteLine("\t\t[7]\tSET THEORY:                         ");
            Console.WriteLine("\t\t[8]\tTRIGONOMETRY:                       ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n\t\t[C]ALCULATOR");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\t\t[E]XIT");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\n\n\t\t ");
            switch (p.iwasBackbottonhehe = Console.ReadLine())
            {
                case "1":
                    MathAlgebra();
                    return;
                case "2":
                    MathArithmetic();
                    return;
                case "3":
                    MathCalculus();
                    return;
                case "4":
                    MathGeometry();
                    return;
                case "5":
                    MathProbabilityandStatistics();
                    return;
                case "6":
                    MathNumberSystem();
                    return;
                case "7":
                    MathSetTheory();
                    return;
                case "8":
                    MathTrigonometry();
                    return;

                case "c":
                case "C":
                    BasicCal();
                    return;

            }
            if (p.iwasBackbottonhehe == "e")
            {
                MainMenu();
            }
            if (p.iwasBackbottonhehe == "E")
            {
                MainMenu();
            }

            else
            {
                //Tetris Beep(1320, 500); Beep(990, 250); Beep(1056, 250); Beep(1188, 250); Beep(1320, 125); Beep(1188, 125); Beep(1056, 250); Beep(990, 250); Beep(880, 500); Beep(880, 250); Beep(1056, 250); Beep(1320, 500); Beep(1188, 250); Beep(1056, 250); Beep(990, 750); Beep(1056, 250); Beep(1188, 500); Beep(1320, 500); Beep(1056, 500); Beep(880, 500); Beep(880, 500); System.Threading.Thread.Sleep(250); Beep(1188, 500); Beep(1408, 250); Beep(1760, 500); Beep(1584, 250); Beep(1408, 250); Beep(1320, 750); Beep(1056, 250); Beep(1320, 500); Beep(1188, 250); Beep(1056, 250); Beep(990, 500); Beep(990, 250); Beep(1056, 250); Beep(1188, 500); Beep(1320, 500); Beep(1056, 500); Beep(880, 500); Beep(880, 500); System.Threading.Thread.Sleep(500);
                //Mario Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
                Console.Beep(700, 800);
            }
            Mathematics(); return;

            void MathAlgebra()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\t\tALGEBRA: ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\tArea of study");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\n\t\tAlgebra is one of the broad areas of mathematics. Roughly speaking, algebra is the study of \n\t\tmathematical symbols and the rules for manipulating these symbols; it is a unifying \n\t\tthread of almost all of mathematics.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\t\t[1]\tCREATOR: ");
                Console.WriteLine("\n\t\t[2]\tBASICS: ");
                Console.WriteLine("\n\t\t[3]\tPROPERTIES: ");
                Console.WriteLine("\n\t\t[4]\tFORMULA: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\t\t[E]XIT");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("\n\t\t ");
                switch (p.iwasBackbottonhehe = Console.ReadLine())
                {
                    case "1": MathAlgCreator(); return;
                    case "2": MathAlgBasics(); return;
                    case "3": MathalgProperties(); return;
                    case "4": MathAlgFormula(); return;
                }
                if (p.iwasBackbottonhehe == "e")
                {
                    Mathematics();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    Mathematics();
                }

                else
                {
                    Console.Beep(700, 800);
                }
                MathAlgebra(); return;
                void MathAlgCreator()
                {
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\t\tMuhammad ibn Musa al-Khwarizmi ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\t\tCreator");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\n\t\tMuhammad ibn Musa al-Khwarizmi was a 9th-century Muslim mathematician and astronomer. He is known \n\t\tas the 'father of algebra', a word derived from the title of his book, Kitab \n\t\tal-Jabr. His pioneering work offered practical answers for land distribution, rules \n\t\ton inheritance and distributing salaries.");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\t\t[E]XIT");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\n\t\t ");

                    switch (p.iwasBackbottonhehe = Console.ReadLine())
                    {
                        case "e": MathAlgebra(); return;
                    }

                    if (p.iwasBackbottonhehe == "E")
                    {
                        MathAlgebra();
                    }

                    else
                    {
                        Console.Beep(700, 800);
                    }
                    MathAlgCreator(); return;
                } //done
                void MathAlgBasics()
                {
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\t\tBASICS: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\n\t\tWhat are the Basics of Algebra? The basics of algebra include numbers, variables, constants, \n\t\texpressions, equations, linear equations, quadratic equations. Further, it involves the \n\t\tbasic arithmetic operations of addition, subtraction, multiplication, and division within \n\t\tthe algebraic expressions.");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\t\t[E]XIT");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\n\t\t ");
                    switch (p.iwasBackbottonhehe = Console.ReadLine())
                    {
                        case "e": MathAlgebra(); return;
                    }

                    if (p.iwasBackbottonhehe == "E")
                    {
                        MathAlgebra();
                    }

                    else
                    {
                        Console.Beep(700, 800);
                    }
                    MathAlgBasics(); return;
                } //done
                void MathalgProperties()
                {
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\t\tPROPERTIES: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\n\t\tThere are four basic properties of numbers: commutative, associative, distributive, and iden\n\t\ttity. You should be familiar with each of these. It is especially important to understand \n\t\tthese properties once you reach advanced math such as algebra and calculus.");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\t\t[E]XIT");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\n\t\t ");
                    switch (p.iwasBackbottonhehe = Console.ReadLine())
                    {
                        case "e": MathAlgebra(); return;
                    }

                    if (p.iwasBackbottonhehe == "E")
                    {
                        MathAlgebra();
                    }

                    else
                    {
                        Console.Beep(700, 800);
                    }
                    MathalgProperties(); return;
                } //done
                void MathAlgFormula()
                {
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\t\tALGEBRA FORMULA:  ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\t\tFormulas");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\n\t\tAlgebra is one of the broad areas of mathematics. Roughly speaking, algebra is the study of \n\t\tmathematical symbols and the rules for manipulating these symbols; it is a unifying \n\t\tthread of almost all of mathematics.");
                    Console.WriteLine(@"
                        a² – b² = (a-b)(a+b)
                        (a + b)² = a² +2ab + b²
                        (a - b)² = a² – 2ab + b²
                        a² +b² = (a - b)² +2ab
                        (a + b + c)² = a²+b²+c²+2ab + 2ac + 2bc
                        (a - b - c)² = a²+b²+c²-2ab - 2ac + 2bc
                        a³-b³ = (a - b)(a² +ab + b²)
                        a³+b³ = (a + b)(a² – ab + b²)
                        (a + b)³ = a³+3a²b + 3ab² +b³
                        (a - b)³ = a³-3a²b + 3ab² – b³
                        “n” is a natural number, an – bn = (a - b)(an - 1 + an - 2b +….bn - 2a + bn - 1)
                        “n” is a even number, an + bn = (a + b)(an - 1 – an - 2b +….+bn - 2a – bn - 1)
                        “n” is an odd number an + bn = (a - b)(an - 1 – an - 2b +…. – bn - 2a + bn - 1)
                        (am)(an) = am + n(ab)m = amn");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\t\t[E]XIT");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\n\t\t ");
                    switch (p.iwasBackbottonhehe = Console.ReadLine())
                    {
                        case "e": MathAlgebra(); return;
                    }

                    if (p.iwasBackbottonhehe == "E")
                    {
                        MathAlgebra();
                    }

                    else
                    {
                        Console.Beep(700, 800);
                    }
                    MathAlgFormula(); return;
                } //done


            } //done

            void MathArithmetic()
            {
                MathNoContent();
            }

            void MathCalculus()
            {
                MathNoContent();
            }

            void MathGeometry()
            {
                MathNoContent();
            }

            void MathProbabilityandStatistics()
            {
                MathNoContent();
            }

            void MathNumberSystem()
            {
                MathNoContent();
            }

            void MathSetTheory()
            {
                MathNoContent();
            }

            void MathTrigonometry()
            {
                MathNoContent();
            }

            void MathNoContent()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(@"      
                                                 /
                              _,.------....___,.' ',.-.
                           ,-'          _,.--' |
                         , '         _.-'.
                        /   ,     , '                   `
                       .   /     /                     ``.
                       |  |     .                       \.\
             ____ | ___._.  | __               \ `.
           .'    `---''       ``'-.--''`  \               .  \
          .  , __               `              |   .
          `, '         ,-'.               \             | L
         , '          '    _.'                -._          /    |
        ,`-.    , '.   `--'                      >.      ,'     |   Coming Soon
       . .'\'   `-'       __,  , -.         /  `.__.-      , '
       ||:, .           , '  ;  /  / \ `        `.    .      .' /
       j |:D  \          `--'  ', '_  . .         `.__, \   , /
      / L:_ |                 .  '' :_;                `.'.'
      .    '''                  ''''''                    V
       `.                                 .    `.   _, ..  `
         `, _.    ._, -'/    .. `,'   __  `
          ) \`._ ___....----''  ,'   .'  \ |   '  \  .
      /   `. '`-.--''         _,' ,'     `---' |    `./  |
      
      ._  `'''--.._____..--'   ,             ' |
      
      | .' `. `-.                /-.           /          ,
      | `._.'    `,_            ;  /         ,'.
      
      .'          /| `-.        . ,'         ,           ,
       '-.__ __ _,','    '`-..___; -...__   ,.'\ ____.___.'
       `''^--'..'   '-`-^-''--    `-^-'`.'''''''`.,^.`.--'");
                switch (p.iwasBackbottonhehe = Console.ReadLine())
                {
                    case "BDGSGSBVRGHSRGHSRGY": Mathematics(); return;

                }
                if (p.iwasBackbottonhehe == "e")
                {
                    Mathematics();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    Mathematics();
                }

                else
                {
                    //Tetris Beep(1320, 500); Beep(990, 250); Beep(1056, 250); Beep(1188, 250); Beep(1320, 125); Beep(1188, 125); Beep(1056, 250); Beep(990, 250); Beep(880, 500); Beep(880, 250); Beep(1056, 250); Beep(1320, 500); Beep(1188, 250); Beep(1056, 250); Beep(990, 750); Beep(1056, 250); Beep(1188, 500); Beep(1320, 500); Beep(1056, 500); Beep(880, 500); Beep(880, 500); System.Threading.Thread.Sleep(250); Beep(1188, 500); Beep(1408, 250); Beep(1760, 500); Beep(1584, 250); Beep(1408, 250); Beep(1320, 750); Beep(1056, 250); Beep(1320, 500); Beep(1188, 250); Beep(1056, 250); Beep(990, 500); Beep(990, 250); Beep(1056, 250); Beep(1188, 500); Beep(1320, 500); Beep(1056, 500); Beep(880, 500); Beep(880, 500); System.Threading.Thread.Sleep(500);
                    //Mario Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
                    Console.Beep(700, 800);
                }
                Mathematics(); return;

            }



            //Calculator
            static void BasicCal()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.Black;

                Console.Clear();
                // Declare variables and then initialize to zero.
                int num1 = 0; int num2 = 0;
                //Console.ForegroundColor = ConsoleColor.Gray;
                //Console.WriteLine("[E]XIT CALCULATOR");

                // Display title as the C# console calculator app.
                Console.WriteLine("\n\n\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\t\tCALCULATOR");

                // Ask the user to type the first number.
                Console.Write("\n\n\n\t\t\t\tFirst No.  \t");
                num1 = Convert.ToInt32(Console.ReadLine());

                // Ask the user to type the second number.
                Console.Write("\n\t\t\t\tSecond No.  \t");
                num2 = Convert.ToInt32(Console.ReadLine());

                // Ask the user to choose an option.
                Console.WriteLine("\t\t\t\tMethod:");
                Console.WriteLine("\n");
                Console.WriteLine("\t\t\t\ta - Add");
                Console.WriteLine("\t\t\t\ts - Subtract");
                Console.WriteLine("\t\t\t\tm - Multiply");
                Console.WriteLine("\t\t\t\td - Divide");
                //Console.Write("Your option? ");

                //Console.Write("\n\n\t\t\t\tPress [E] to close Calculator.");

                // Use a switch statement to do the math.
                switch (p.iwasBackbottonhehe = Console.ReadLine())
                {
                    case "a":
                        Console.WriteLine($"\t\t\t\tAnswer: {num1} + {num2} = " + (num1 + num2));
                        break;
                    case "s":
                        Console.WriteLine($"\t\t\t\tAnswer: {num1} - {num2} = " + (num1 - num2));
                        break;
                    case "m":
                        Console.WriteLine($"\t\t\t\tAnswer: {num1} * {num2} = " + (num1 * num2));
                        break;
                    case "d":
                        Console.WriteLine($"\t\t\t\tAnswer: {num1} / {num2} = " + (num1 / num2));
                        break;

                }
                if (p.iwasBackbottonhehe == "e")
                {
                    Mathematics();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    Mathematics();
                }
                else
                {
                    Console.Beep(700, 800);
                }
                BasicCal(); return;




                // Wait for the user to respond before closing.


            }
        } //In Progress-


















        //Science
        /// <summary>
        /// Nothing here
        /// </summary>
        private static void Science()
        {

            Program p = new();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;


            Console.Write(@"          
          ███████╗ ██████╗██╗███████╗███╗   ██╗ ██████╗███████╗
          ██╔════╝██╔════╝██║██╔════╝████╗  ██║██╔════╝██╔════╝
          ███████╗██║     ██║█████╗  ██╔██╗ ██║██║     █████╗  
          ╚════██║██║     ██║██╔══╝  ██║╚██╗██║██║     ██╔══╝  
          ███████║╚██████╗██║███████╗██║ ╚████║╚██████╗███████╗
          ╚══════╝ ╚═════╝╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝╚══════╝
                                                     ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\t\t [1] \tANATOMY");

            Console.WriteLine("\t\t [2] \tANTHROPOLOGY");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t [3] \tBIOLOGY");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t [4] \tCHEMISTRY");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t\t [5] \tECOLOGY");
            Console.WriteLine("\t\t [6] \tECONOMY");
            Console.WriteLine("\t\t [7] \tGEOGRAPHY");
            Console.WriteLine("\t\t [8] \tLAWS");
            Console.WriteLine("\t\t [9] \tLOGIC");
            Console.WriteLine("\t\t [10] \tMATH");
            Console.WriteLine("\t\t [11] \tPHILOSOPHY");
            Console.WriteLine("\t\t [12] \tPHYSICS");
            Console.WriteLine("\t\t [13] \tPSYCHOLOGY");
            Console.WriteLine("\t\t [14] \tSOCIOLOGY");
            Console.WriteLine("\t\t [15] \tSTATISTICS");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\t\t[E]XIT ");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\n\t\t ");


            switch (p.iwasBackbottonhehe = Console.ReadLine())
            {
                case "1": sciAnatomy(); return;
                case "2": sciAnthropology(); return;
                case "3": sciBiology(); return;
                case "4": sciChemistry(); return;
                case "5": sciEcology(); return;
                case "6": sciEconomy(); return;
                case "7": sciGeography(); return;
                case "8": sciLaws(); return;
                case "9": sciLogic(); return;
                case "10": sciMath(); return;
                case "11": sciPhilosophy(); return;
                case "12": sciPhysics(); return;
                case "13": sciPsycology(); return;
                case "14": sciSociology(); return;
                case "15": sciStatistics(); return;

            }
            if (p.iwasBackbottonhehe == "e")
            {
                MainMenu();
            }
            if (p.iwasBackbottonhehe == "E")
            {
                MainMenu();
            }
            else
            {
                Console.Beep(700, 800);
            }
            Science(); return;

            void ScienceNoContent()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(@"
                                           /
                        _,.------....___,.' ',.-.
                     ,-'          _,.--' |
                   , '         _.-'.
                  /   ,     , '                   `
                 .   /     /                     ``.
                 |  |     .                       \.\
       ____ | ___._.  | __               \ `.
     .'    `---''       ``'-.--''`  \               .  \
    .  , __               `              |   .
    `, '         ,-'.               \             | L
   , '          '    _.'                -._          /    |
  ,`-.    , '.   `--'                      >.      ,'     |   SORRY NO AVAILABLE CONTENT
 . .'\'   `-'       __,  , -.         /  `.__.-      , '
 ||:, .           , '  ;  /  / \ `        `.    .      .' /
 j |:D  \          `--'  ', '_  . .         `.__, \   , /
/ L:_ |                 .  '' :_;                `.'.'
.    '''                  ''''''                    V
 `.                                 .    `.   _, ..  `
   `, _.    ._, -'/    .. `,'   __  `
    ) \`._ ___....----''  ,'   .'  \ |   '  \  .
/   `. '`-.--''         _,' ,'     `---' |    `./  |

._  `'''--.._____..--'   ,             ' |

| .' `. `-.                /-.           /          ,
| `._.'    `,_            ;  /         ,'.

.'          /| `-.        . ,'         ,           ,
 '-.__ __ _,','    '`-..___; -...__   ,.'\ ____.___.'
 `''^--'..'   '-`-^-''--    `-^-'`.'''''''`.,^.`.--'");
                Console.Beep(600, 1000);
                switch (p.iwasBackbottonhehe = Console.ReadLine()) { case "e": Science(); return; }

                if (p.iwasBackbottonhehe == "E")
                {
                    Science();
                }
                else
                {
                    Console.Beep(700, 800);
                }
                Science();
            } //use this if there's no available content in science :)


            void sciAnatomy()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\t\tANATOMY: ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\tField of study");
                Console.ForegroundColor = ConsoleColor.White;
                //embryology, gross anatomy, zootomy, phytotomy, human anatomy, and comparative anatomy.
                Console.WriteLine("\n");
                Console.WriteLine("\n\t\t[1] HISTOLOGY");
                Console.WriteLine("\t\t[2] EMBRYOLOGY");
                Console.WriteLine("\t\t[3] GROSS ANATOMY");
                Console.WriteLine("\t\t[4] ZOOTOMY");
                Console.WriteLine("\t\t[5] PHYTOTOMY");
                Console.WriteLine("\t\t[6] HUMAN ANATOMY");
                Console.WriteLine("\t\t[7] COMPARARIVE ANATOMY");
                Console.WriteLine("\n\n\t\t[I]NFO ABOUT ANATOMY.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\t\t[E]XIT");

                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("\n\t\t ");

                switch (p.iwasBackbottonhehe = Console.ReadLine())
                {
                    case "1": sciAnaHistology(); return;
                    case "2": sciAnaEmbryology(); return;
                    case "3": sciAnaGrossAnatomy(); return;
                    case "4": sciAnaZootomy(); return;
                    case "5": sciAnaPhytotomy(); return;
                    case "6": sciAnaHumanAnatomy(); return;
                    case "7": sciAnaComparativeAnatomy(); return;
                    case "i": sciAnaAnatomyInfo(); return;
                        //case "": sciAnatomy();return;
                        //case "e": Science(); return;
                }
                if (p.iwasBackbottonhehe == "e")
                {
                    Science();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    Science();
                }
                else
                {
                    Console.Beep(700, 800);
                }
                sciAnatomy(); return;




                void sciAnaHistology()
                {
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\n");
                    Console.WriteLine("\t\tHISTOLOGY: ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\t\tField of study");

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\n\t\tHistology, also known as microscopic anatomy or microanatomy, is the branch of \n\t\tbiology which studies the microscopic anatomy of biological tissues. Histology is the microscopic \n\t\tcounterpart to gross anatomy, which looks at larger structures visible without a microscope.");

                    Console.WriteLine("\n\t\t[1]\tMedical Terminilogy: ");
                    Console.WriteLine("\t\t[2]\tGrades: ");
                    Console.WriteLine("\t\t[3]\tSteps: ");
                    Console.WriteLine("\t\t[4]\tScore: ");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\t\t[E]XIT ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\t\t ");

                    switch (p.iwasBackbottonhehe = Console.ReadLine())
                    {
                        case "1": sciAnaHistologyMedicalTerminilogy(); return;
                        case "2": sciAnaHistologyGrades(); return;
                        case "3": sciAnaHistologySteps(); return;
                        case "4": sciAnaHistologyScore(); return;
                    }
                    //switch(p.iwasBackbottonhehe = Console.ReadLine())
                    if (p.iwasBackbottonhehe == "e")
                    {
                        sciAnatomy();
                    }
                    if (p.iwasBackbottonhehe == "E")
                    {
                        sciAnatomy();
                    }
                    else
                    {
                        ;
                    }
                    sciAnaHistology(); return;





                    void sciAnaHistologyMedicalTerminilogy()
                    {
                        Program p = new();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\n\n");
                        Console.WriteLine("\t\tMEDICAL TERMINOLOGY: ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("\t\tMedical Definition of histology");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\n\n\t\t1: a branch of anatomy that deals with the minute structure of animal and plant \n\t\t   tissues as discernible with the microscope — compare gross anatomy. ");
                        Console.WriteLine("\n\t\t2: a treatise on histology. ");
                        Console.WriteLine("\n\t\t3: tissue structure or organization.");


                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\n\t\t[E]XIT ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\t\t ");
                        p.iwasBackbottonhehe = Console.ReadLine();
                        if (p.iwasBackbottonhehe == "e")
                        {
                            sciAnaHistology();
                        }
                        if (p.iwasBackbottonhehe == "E")
                        {
                            sciAnaHistology();
                        }
                        else
                        {
                            ;
                        }
                        sciAnaHistologyMedicalTerminilogy(); return;


                        //switch (Console.ReadLine())
                        //{
                        //    case "":sciAnaHistologyMedicalTerminilogy();return;
                        //    case "e":sciAnaHistology();return;
                        //}
                    }//done
                    void sciAnaHistologyGrades()
                    {
                        Program p = new();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\n\n");
                        Console.WriteLine("\t\tGRADES: ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("\t\tHistological Grades ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\n\n\t\t1: One of the best-established prognostic factors in breast cancer is histological \n\t\tgrade, which represents the morphological assessment of tumor biological char-\n\t\tacteristics and has been shown to be able to generate important information related \n\t\tto the clinical behavior of breast cancers. ");



                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\n\t\t[E]XIT ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\t\t ");

                        p.iwasBackbottonhehe = Console.ReadLine();
                        if (p.iwasBackbottonhehe == "e")
                        {
                            sciAnaHistology();
                        }
                        if (p.iwasBackbottonhehe == "E")
                        {
                            sciAnaHistology();
                        }
                        else
                        {
                            ;
                        }
                        sciAnaHistologyGrades(); return;
                        //switch (Console.ReadLine())
                        //{
                        //    case "": sciAnaHistologyGrades(); return;
                        //    case "e": sciAnaHistology(); return;
                        //}
                    }//done
                    void sciAnaHistologySteps()
                    {
                        Program p = new();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\n\n");
                        Console.WriteLine("\t\tSTEPS IN HISTOLOGY: ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("\t\tThe Five Steps of Histology Slide Preparation ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\n\t\t1. Tissue fixation ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine(@"Slide preparation begins with the fixation of your tissue specimen. This is a crucial step in tissue preparation, and its purpose is to prevent tissue autolysis and putrefaction. For best results, your biological tissue samples should be transferred into fixative immediately after collection.

Although there are many types of fixative, most specimens are fixed in 10 % neutral buffered formalin. The optimum formalin - to - specimen volume ratio should be at least 10:1(e.g., 10ml of formalin per 1 cm3 of tissue).This will allow most tissues to become adequately fixed within 24 - 48 hours.Formalin containers should be capped and leak - proof, and labeled correctly.");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\n\t\t2. Specimen Transfer to Cassettes ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine(@"After fixation, specimens are trimmed using a scalpel to enable them to fit into an appropriately labeled tissue cassette. Specimens should not be so big that they fill the cassette – they are trimmed so as not to touch the edges. Additionally, they must not be too thick (ideally they should be less than 4 mm), otherwise, they risk being “waffled” when the cassette lid is closed. The filled tissue cassettes are then stored in formalin until processing begins. ");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\n\t\t3. Tissue Processing ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine(@"Processing tissues into thin microscopic sections is usually done using a paraffin block, as follows:

Dehydration, which involves immersing your specimen in increasing concentrations of alcohol to remove the water and formalin from the tissue.
Clearing, in which an organic solvent such as xylene is used to remove the alcohol and allow infiltration with paraffin wax.
Embedding, where specimens are infiltrated with the embedding agent – usually paraffin wax. The tissue becomes surrounded by a large block of molten paraffin wax, creating what is now referred to as the “block”.  Once the block solidifies, it provides a support matrix that allows very thin sectioning. ");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\n\t\t4. Sectioning ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine(@"Your tissue specimen is now ready to be cut into sections that can be placed on a slide.

Wax is removed from the surface of the block to expose the tissue.
Blocks are chilled on a refrigerated plate or ice tray for 10 minutes before sectioning.
A microtome is used to slice extremely thin tissue sections off the block in the form of a ribbon.
The microtome can be pre-set to cut at different thicknesses, but most tissues are cut at around 5 µm. You can discover more ways to slice tissue sections here.

Once cut, the tissue ribbons are carefully transferred to a warm water bath. Here they are allowed to float on the surface, and can then be scooped up onto a slide placed under the water level. Charged slides work best for this process – they improve tissue adhesion to the glass, and help to reduce the chance of sections washing off the slide during staining.

Slides should be clearly labeled, and then allowed to dry upright at 37oC for a few hours to gently melt the excess paraffin wax, leaving the tissue section intact. ");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\n\t\t5. Staining ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine(@"Most cells are transparent and appear almost colorless when unstained. Histochemical stains (typically hematoxylin and eosin) are therefore used to provide contrast to tissue sections, making tissue structures more visible and easier to evaluate.  Following staining, a coverslip is mounted over the tissue specimen on the slide, using optical grade glue, to help protect the specimen. ");



                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\n\t\t[E]XIT ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\t\t ");

                        p.iwasBackbottonhehe = Console.ReadLine();
                        if (p.iwasBackbottonhehe == "e")
                        {
                            sciAnaHistology();
                        }
                        if (p.iwasBackbottonhehe == "E")
                        {
                            sciAnaHistology();
                        }
                        else
                        {
                            ;
                        }
                        sciAnaHistologySteps(); return;

                    }//done
                    void sciAnaHistologyScore()
                    {
                        Program p = new();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\n\n");
                        Console.WriteLine("\t\tSCORE: ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("\t\tHistology Score ");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\n");
                        Console.WriteLine("\n\t\tThe Nottingham histologic score (or histologic grade) is simply a scoring system to \n\t\tassess the 'grade' of breast cancers. The grade is a way to rate how aggressive a tumor \n\t\tmay behave. Nottingham is a total of 3 different scores.");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\n\t\t[E]XIT ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\t\t ");
                        p.iwasBackbottonhehe = Console.ReadLine();
                        if (p.iwasBackbottonhehe == "e")
                        {
                            sciAnaHistology();
                        }
                        if (p.iwasBackbottonhehe == "E")
                        {
                            sciAnaHistology();
                        }
                        else
                        {
                            ;
                        }
                        sciAnaHistologyScore(); return;

                    }//done





                }//Histology Done!
                void sciAnaEmbryology()
                {
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\n");
                    Console.WriteLine("\t\tEMBRYOLOGY: ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\t\tField of study");

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\n\t\tEmbryology is the branch of biology that studies the prenatal development of gametes, \n\t\tfertilization, and development of embryos and fetuses. Additionally, embryology encompasses the \n\t\tstudy of congenital disorders that occur before birth, known as teratology.");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\t\tBasis: ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\n\t\tEmbryology is the basis for understanding the intimate relation between structures in \n\t\tdifferent organ systems, such as the nervous system and muscle, and is primordial for understanding \n\t\tdisorders of development that in the human may present as one of the congenital myopathies.");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\t\t[E]XIT ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\t\t ");


                    switch (p.iwasBackbottonhehe = Console.ReadLine())
                    {
                        case "e": sciAnatomy(); return;
                    }
                    if (p.iwasBackbottonhehe == "E")
                    {
                        sciAnatomy();
                    }
                    else
                    {
                        Console.Beep(700, 800);
                    }
                    sciAnaEmbryology(); return;
                }//done

                void sciAnaGrossAnatomy()
                {
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\n");
                    Console.WriteLine("\t\tGROSS ANATOMY: ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\t\tField of study");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\n\t\tGross anatomy is the study of anatomy at the visible or macroscopic level. The counterpart \n\t\tto gross anatomy is the field of histology, which studies microscopic anatomy.");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\t\tCategories: ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\n\t\tGross anatomy is subdivided into surface anatomy (the external body), regional anatomy \n\t\t(specific regions of the body), and systemic anatomy (specific organ systems).");
                    Console.WriteLine("\n\t\tMicroscopic anatomy is subdivided into cytology (the study of cells) and histology (the \n\t\tstudy of tissues).");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\t\tFunction: ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\n\t\tGross anatomy of the human body or other animals seeks to understand the relationship \n\t\tbetween components of an organism in order to gain a greater appreciation of the roles of those components \n\t\tand their relationships in maintaining the functions of life.");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\t\t[E]XIT ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\t\t ");


                    switch (p.iwasBackbottonhehe = Console.ReadLine())
                    {
                        case "e": sciAnatomy(); return;
                    }
                    if (p.iwasBackbottonhehe == "E")
                    {
                        sciAnatomy();
                    }
                    else
                    {
                        Console.Beep(700, 800);
                    }
                    sciAnaGrossAnatomy(); return;
                }//done

                void sciAnaZootomy()
                {
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\n");
                    Console.WriteLine("\t\tZOOTOMY: ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\t\tField of study");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\n\t\tZootomy. / (zəʊˈɒtəmɪ) / noun. the branch of zoology concerned with the dissection and \n\t\tanatomy of animals.");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\t\t[E]XIT ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\t\t ");


                    switch (p.iwasBackbottonhehe = Console.ReadLine())
                    {
                        case "e": sciAnatomy(); return;
                    }
                    if (p.iwasBackbottonhehe == "E")
                    {
                        sciAnatomy();
                    }
                    else
                    {
                        Console.Beep(700, 800);
                    }
                    sciAnaZootomy(); return;
                }//done

                void sciAnaPhytotomy()
                {
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\n");
                    Console.WriteLine("\t\tPHYTOTOMY / PLANT ANATOMY: ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\t\tField of study");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\n\t\tPlant anatomy or phytotomy is the general term for the study of the internal structure \n\t\tof plants. Originally it included plant morphology, the description of the physical form and \n\t\texternal structure of plants, but since the mid-20th century plant anatomy has been considered a separate \n\t\tfield referring only to internal plant structure. Plant anatomy is now frequently investigated \n\t\tat the cellular level, and often involves the sectioning of tissues and microscopy.");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\t\t[E]XIT ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\t\t ");


                    switch (p.iwasBackbottonhehe = Console.ReadLine())
                    {
                        case "e": sciAnatomy(); return;
                    }
                    if (p.iwasBackbottonhehe == "E")
                    {
                        sciAnatomy();
                    }
                    else
                    {
                        Console.Beep(700, 800);
                    }
                    sciAnaPhytotomy(); return;
                }//done

                void sciAnaHumanAnatomy()
                {
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\n");
                    Console.WriteLine("\t\tHUMAN ANATOMY / HUMAN BODY: ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\t\tField of study");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\n\t\tThe human body is the structure of a human being. It is composed of many different types \n\t\tof cells that together create tissues and subsequently organ systems. They ensure homeostasis and the \n\t\tviability of the human body.");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\t\t[E]XIT ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\t\t ");


                    switch (p.iwasBackbottonhehe = Console.ReadLine())
                    {
                        case "e": sciAnatomy(); return;
                    }
                    if (p.iwasBackbottonhehe == "E")
                    {
                        sciAnatomy();
                    }
                    else
                    {
                        Console.Beep(700, 800);
                    }
                    sciAnaHumanAnatomy(); return;
                }//done//done

                void sciAnaComparativeAnatomy()
                {
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\n");
                    Console.WriteLine("\t\tCOMPARATIVE ANATOMY: ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\t\tField of study");

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\n\t\tComparative anatomy is the study of similarities and differences in the anatomy of \n\t\tdifferent species. It is closely related to evolutionary biology and phylogeny.");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\t\t[E]XIT ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\t\t ");


                    switch (p.iwasBackbottonhehe = Console.ReadLine()) { case "e": Science(); return; }

                    if (p.iwasBackbottonhehe == "E")
                    {
                        sciAnatomy();
                    }
                    else
                    {
                        Console.Beep(700, 800);
                    }
                    sciAnaComparativeAnatomy(); return;
                }//done

                void sciAnaAnatomyInfo()
                {
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\n");
                    Console.WriteLine("\t\tANATOMY: ");                                                                      //cuthere
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\n\t\tAccording to some experts on the subject, this discipline constitutes one of the \n\t\tcurrent branches of Medicine; However, given its great importance, we have found it pert\n\t\tinent to treat it separately. From this link, you will be able to know all the branches of Anatomy \n\t\tthat today are taken into account in medical, academic and work areas.");
                    Console.WriteLine("\n\t\tAnatomy, in a general way, takes into account the physical constitution of the \n\t\thuman body (and also of other living beings), understanding it as a complex network of syst\n\t\t-ems and devices.");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\t\t[E]XIT ");

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\n\n\t\t ");

                    switch (p.iwasBackbottonhehe = Console.ReadLine())
                    {
                        case "e": sciAnatomy(); return;
                    }
                    if (p.iwasBackbottonhehe == "E")
                    {
                        sciAnatomy();
                    }
                    else
                    {
                        Console.Beep(700, 800);
                    }
                    sciAnaAnatomyInfo(); return;
                }//done


            }//done

            void sciAnthropology()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tANTHROPOLOGY: ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\tField of study");
                Console.ForegroundColor = ConsoleColor.White;
                //embryology, gross anatomy, zootomy, phytotomy, human anatomy, and comparative anatomy.
                Console.WriteLine("\n");
                Console.WriteLine("\n\t\t[1] CITATION");
                Console.WriteLine("\t\t[2] METHODS");
                Console.WriteLine("\t\t[3] RESEARCH");
                Console.WriteLine("\t\t[4] ABOUT");
                Console.WriteLine("\n\n\t\t[I]NFO ABOUT ANATOMY.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\t\t[E]XIT");

                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("\n\t\t ");

                switch (p.iwasBackbottonhehe = Console.ReadLine())
                {
                    case "i": case "I": sciAntAthropologyInfo(); return;
                    case "1": sciAntCitation(); return;
                    case "2": sciAntMethods(); return;
                    case "3": sciAntResearch(); return;
                    case "4": sciAntAbout(); return;

                }
                if (p.iwasBackbottonhehe == "e")
                {
                    Science();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    Science();
                }
                else
                {
                    Console.Beep(700, 800);
                }
                sciAnthropology(); return;


                void sciAntCitation()
                {
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\n\t\tCITATION");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\t\tAnthropology Guides");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\t\tAnthropology professors will often require you to use Chicago Manual of Style Author-Date format for \n\t\tyour in-text citations and references. CMS Author-Date is the official citation format for \n\t\tThe American Anthropological Association.");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\t\t[E]XIT");

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\n\t\t ");
                    switch (p.iwasBackbottonhehe = Console.ReadLine())
                    {
                        case "e": sciAnthropology(); return;
                    }
                    if (p.iwasBackbottonhehe == "E")
                    {
                        sciAnthropology();
                    }
                    else
                    {
                        Console.Beep(700, 800);
                    }
                    sciAntCitation(); return;
                }//done
                void sciAntMethods()
                {
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\n\t\tMETHODS");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\t\tField of study");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\t\tFour common qualitative anthropological data collection methods are: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\t\t(1) participant observation \n\n\t\t(2) in-depth interviews \n\n\t\t(3) focus groups \n\n\t\t(4) textual analysis. Participant Observation. Participant observation is \n\t\tthe quintessential fieldwork method in anthropology.");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\t\t[E]XIT");

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\n\t\t ");
                    switch (p.iwasBackbottonhehe = Console.ReadLine())
                    {
                        case "e": sciAnthropology(); return;
                    }
                    if (p.iwasBackbottonhehe == "E")
                    {
                        sciAnthropology();
                    }
                    else
                    {
                        Console.Beep(700, 800);
                    }
                    sciAntMethods(); return;
                }//done
                void sciAntResearch()
                {
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\n\t\tRESEARCH");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\t\tField of study");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\t\tMeaning. Anthropological research deals largely with qualitative aspects and focuses on the creation \n\t\tand transmission of meaning. Meaning is mediated through language and action and the best way of \n\t\tunderstanding this is through observation and engagement that is difficult through more \n\t\t'traditional' research methods.");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\t\t[E]XIT");

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\n\t\t ");
                    switch (p.iwasBackbottonhehe = Console.ReadLine())
                    {
                        case "e": sciAnthropology(); return;
                    }
                    if (p.iwasBackbottonhehe == "E")
                    {
                        sciAnthropology();
                    }
                    else
                    {
                        Console.Beep(700, 800);
                    }
                    sciAntResearch(); return;
                }//ndone
                void sciAntAbout()
                {
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\n\t\tABOUT?");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\t\tField of study");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\t\tanthropology, “the science of humanity,” which studies human beings in aspects ranging from the biology \n\t\tand evolutionary history of Homo sapiens to the features of society and culture that \n\t\tdecisively tdistinguish humans from other animal species.");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\t\t[E]XIT");

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\n\t\t ");
                    switch (p.iwasBackbottonhehe = Console.ReadLine())
                    {
                        case "e": sciAnthropology(); return;
                    }
                    if (p.iwasBackbottonhehe == "E")
                    {
                        sciAnthropology();
                    }
                    else
                    {
                        Console.Beep(700, 800);
                    }
                    sciAntAbout(); return;
                }//done

                void sciAntAthropologyInfo()
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\n");
                    Console.WriteLine("\t\tANTHROPOLOGY: ");                                                                      //cuthere
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\n\t\tAnthropology is the scientific study of humanity, concerned with human behavior, human \n\t\tbiology, cultures, societies, and linguistics, in both the present and past, including past human species.");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\t\t[E]XIT ");

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\n\n\t\t ");

                    switch (p.iwasBackbottonhehe = Console.ReadLine())
                    {

                    }
                    if (p.iwasBackbottonhehe == "e")
                    {
                        sciAnthropology();
                    }
                    if (p.iwasBackbottonhehe == "E")
                    {
                        sciAnthropology();
                    }
                    else
                    {
                        Console.Beep(700, 800);
                    }
                    sciAntAthropologyInfo(); return;

                }//done

            }//done

            void sciBiology()
            {
                ScienceNoContent();
            }//noinput

            void sciChemistry()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\n");
                Console.WriteLine("\t\t[1]\t\tPERIODIC TABLE");



                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\n\t\t[E]XIT");

                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("\n\t\t ");



                switch (p.iwasBackbottonhehe = Console.ReadLine())
                {
                    case "1":
                        sciChemTable();
                        return;
                }
                if (p.iwasBackbottonhehe == "e")
                {
                    Science();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    Science();
                }
                else
                {
                    Console.Beep(700, 800);
                }
                sciChemistry(); return;

                void sciChemTable()
                {
                    Program p = new();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(@"          
        ╔═╗╔═╗╦═╗╦╔═╗╔╦╗╦╔═╗  ╔╦╗╔═╗╔╗ ╦  ╔═╗  ╔═╗╔═╗  ╔╦╗╦ ╦╔═╗  ╔═╗╦  ╔═╗╔╦╗╔═╗╔╗╔╔╦╗╔═╗
        ╠═╝║╣ ╠╦╝║║ ║ ║║║║     ║ ╠═╣╠╩╗║  ║╣   ║ ║╠╣    ║ ╠═╣║╣   ║╣ ║  ║╣ ║║║║╣ ║║║ ║ ╚═╗
        ╩  ╚═╝╩╚═╩╚═╝═╩╝╩╚═╝   ╩ ╩ ╩╚═╝╩═╝╚═╝  ╚═╝╚     ╩ ╩ ╩╚═╝  ╚═╝╩═╝╚═╝╩ ╩╚═╝╝╚╝ ╩ ╚═╝");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(@"    
           __________________________________________________________________________     
          |   1   2   3   4   5   6   7   8   9   10  11  12  13  14  15  16  17  18 |    INSTRUCTION:
          |                                                                          |      When Using, Type the exact 
          |1  H                                                                   He |      symbol on screen.
          |                                                                          |    
          |2  Li  Be                                          B   C   N   O   F   Ne |    
          |                                                                          |    
          |3  Na  Mg                                          Al  Si  P   S   Cl  Ar |    
          |                                                                          |    
          |4  K   Ca  Sc  Ti  V   Cr  Mn  Fe  Co  Ni  Cu  Zn  Ga  Ge  As  Se  Br  Kr |    
          |                                                                          |    
          |5  Rb  Sr  Y   Zr  Nb  Mo  Tc  Ru  Rh  Pd  Ag  Cd  In  Sn  Sb  Te  I   Xe |    
          |                                                                          |    
          |6  Cs  Ba  *   Hf  Ta  W   Re  Os  Ir  Pt  Au  Hg  Tl  Pb  Bi  Po  At  Rn |    
          |                                                                          |    
          |7  Fr  Ra  **  Rf  Db  Sg  Bh  Hs  Mt  Ds  Rg  Cn  Nh  Fl  Mc  Lv  Ts  Og |    
          |__________________________________________________________________________|    
          |                                                                          |    [1]INFO
          |                                                                          |    [2]CRDT
          | Lantanoidi*   La  Ce  Pr  Nd  Pm  Sm  Eu  Gd  Tb  Dy  Ho  Er  Tm  Yb  Lu |    
          |                                                                          |    
          |  Aktinoidi**  Ac  Th  Pa  U   Np  Pu  Am  Cm  Bk  Cf  Es  Fm  Md  No  Lr |    [E]XIT
          |__________________________________________________________________________|    
          ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Search Element: ");
                    switch (p.iwasBackbottonhehe = Console.ReadLine())
                    {
                        case "1": InfoChemTable(); return;
                        case "2": CrdtChemTable(); return;
                        case "H": Hydrogen(); return;
                        case "He": Helium(); return;
                        case "Li": Lithim(); return;
                        case "Be": Beryllium(); return;
                        case "B": Boron(); return;
                        case "C": Carbon(); return;
                        case "N": Nitrogen(); return;
                        case "O": Oxygen(); return;
                        case "F": Flourione(); return;
                        case "Ne": Neo(); return;
                        case "Na": Sodium(); return;
                        case "Mg": Magnesium(); return;
                        case "Al": Aluminum(); return;
                        case "Si": Silicon(); return;
                        case "P": Phosphorus(); return;
                        case "S": Sulfur(); return;
                        case "Cl": Chlorine(); return;
                        case "Ar": Argon(); return;
                        case "K": Potassium(); return;
                        case "Ca": Calcium(); return;
                        case "Sc": Scandium(); return;
                        case "Ti": Titanium(); return;
                        case "V": Vanadium(); return;
                        case "Cr": Chromium(); return;
                        case "Mn": Manganese(); return;
                        case "Fe": Iron(); return;
                        case "Co": Cobalt(); return;
                        case "Ni": Nickel(); return;
                        case "Cu": Copper(); return;
                        case "Zn": Zinc(); return;
                        case "Ga": Gallium(); return;
                        case "Ge": Germanium(); return;
                        case "As": Arsenic(); return;
                        case "Se": Selenium(); return;
                        case "Br": Bromine(); return;
                        case "Kr": Krypton(); return;
                        case "Rb": Rubidium(); return;
                        case "Sr": Strontium(); return;
                        case "Y": Yttrium(); return;
                        case "Zr": Zirconium(); return;
                        case "Nb": Niobium(); return;
                        case "Mo": Molybdenum(); return;
                        case "Tc": Technetium(); return;
                        case "Ru": Ruthenium(); return;
                        case "Rh": Rhodium(); return;
                        case "Pd": Palladium(); return;
                        case "Ag": Silver(); return;
                        case "Cd": Cadmium(); return;
                        case "In": Indium(); return;
                        case "Sn": Tin(); return;
                        case "Sb": Antimony(); return;
                        case "Te": Tellurium(); return;
                        case "I": Iodine(); return;
                        case "Xe": Xenon(); return;
                        case "Cs": Cesium(); return;
                        case "Ba": Barium(); return;
                        case "La": Lanthanum(); return;
                        case "Ce": Cerium(); return;
                        case "Pr": Praseodymium(); return;
                        case "Nd": Neodymium(); return;
                        case "Pm": Promethium(); return;
                        case "Sm": Samarium(); return;
                        case "Eu": Europium(); return;
                        case "Gd": Gadolinium(); return;
                        case "Tb": Terbium(); return;
                        case "Dy": Dysprosium(); return;
                        case "Ho": Holmium(); return;
                        case "Er": Erbium(); return;
                        case "Tm": Thullium(); return;
                        case "Yb": Ytterbium(); return;
                        case "Lu": Lutetium(); return;
                        case "Hf": Hafnium(); return;
                        case "Ta": Tantalum(); return;
                        case "W": Tungsten(); return;
                        case "Re": Rhenium(); return;
                        case "Os": Osmium(); return;
                        case "Ir": Iridium(); return;
                        case "Pt": Platinum(); return;
                        case "Au": Gold(); return;
                        case "Hg": Mercury(); return;
                        case "Tl": Thallium(); return;
                        case "Pb": Lead(); return;
                        case "Bi": Bismuth(); return;
                        case "Po": Polonium(); return;
                        case "At": Astatine(); return;
                        case "Rn": Radon(); return;
                        case "Fr": Francium(); return;
                        case "Ra": Radium(); return;
                        case "Ac": Actinium(); return;
                        case "Th": Thorium(); return;
                        case "Pa": Protactinium(); return;
                        case "U": Uranium(); return;
                        case "Np": Neptunium(); return;
                        case "Pu": Plutonium(); return;
                        case "Am": Americium(); return;
                        case "Cm": Curium(); return;
                        case "Bk": Berkelium(); return;
                        case "Cf": Californium(); return;
                        case "Es": Einsteinium(); return;
                        case "Fm": Fermium(); return;
                        case "Md": Mendelevium(); return;
                        case "No": Nobelium(); return;
                        case "Lr": Lawrencium(); return;
                        case "Rf": Rutherfordium(); return;
                        case "Db": Dubnium(); return;
                        case "Sg": Seaborgium(); return;
                        case "Bh": Bohrium(); return;
                        case "Hs": Hassium(); return;
                        case "Mt": Meitnerium(); return;
                        case "Ds": Darmstadtium(); return;
                        case "Rg": Reontgenium(); return;
                        case "Cn": Copernicium(); return;
                        case "Nh": Nihonium(); return;
                        case "Fl": Flerovium(); return;
                        case "Mc": Moscovium(); return;
                        case "Lv": Livermorium(); return;
                        case "Ts": Tennesine(); return;
                        case "Og": Oganesson(); return;
                    }
                    if (p.iwasBackbottonhehe == "e")
                    {
                        sciChemistry();
                    }
                    if (p.iwasBackbottonhehe == "E")
                    {
                        sciChemistry();
                    }
                    else
                    {
                        Console.Beep(700, 800);
                    }
                    sciChemTable(); return;

                    void ScienceChemNoContent()
                    {
                        Program p = new();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(@"     
                                                /
                             _,.------....___,.' ',.-.
                          ,-'          _,.--' |
                        , '         _.-'.
                       /   ,     , '                   `
                     .   /     /                     ``.
                      |  |     .                       \.\
            ____ | ___._.  | __               \ `.
          .'    `---''       ``'-.--''`  \               .  \
         .  , __               `              |   .
         `, '         ,-'.               \             | L
        , '          '    _.'                -._          /    |
       ,`-.    , '.   `--'                      >.      ,'     |   ELEMENT NOT AVAILABLE YET:(
      . .'\'   `-'       __,  , -.         /  `.__.-      , '
      ||:, .           , '  ;  /  / \ `        `.    .      .' /
      j |:D  \          `--'  ', '_  . .         `.__, \   , /
     / L:_ |                 .  '' :_;                `.'.'
     .    '''                  ''''''                    V
      `.                                 .    `.   _, ..  `
        `, _.    ._, -'/    .. `,'   __  `
         ) \`._ ___....----''  ,'   .'  \ |   '  \  .
     /   `. '`-.--''         _,' ,'     `---' |    `./  |

     ._  `'''--.._____..--'   ,             ' |

     | .' `. `-.                /-.           /          ,
     | `._.'    `,_            ;  /         ,'.

     .'          /| `-.        . ,'         ,           ,
      '-.__ __ _,','    '`-..___; -...__   ,.'\ ____.___.'
      `''^--'..'   '-`-^-''--    `-^-'`.'''''''`.,^.`.--'");
                        Console.Beep(600, 1000);
                        switch (p.iwasBackbottonhehe = Console.ReadLine()) { case "e": sciChemTable(); return; }

                        if (p.iwasBackbottonhehe == "E")
                        {
                            sciChemTable();
                        }
                        else
                        {
                            Console.Beep(700, 800);
                        }
                        sciChemTable();
                    }
                    void InfoChemTable()
                    {
                        Program p = new();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\n\t\t\t\t\t\tSOLE PROGRAMMER:");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n\t\t\t\t\t\t\t\tJOHN PHILIP GARDIOLA SABINET");
                        Console.WriteLine("\t\t\t\t\t\t\t\tjohnphilip.sabinet@lspu.edu.ph");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\n\n\n\n\t\t\t\t\t\t[E]XIT");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(" ");
                        switch (p.iwasBackbottonhehe = Console.ReadLine())
                        {
                            case "e":
                                sciChemTable();
                                return;
                        }
                        if (p.iwasBackbottonhehe == "E")
                        {
                            sciChemTable();
                            return;
                        }
                        else
                        {
                            Console.Beep(700, 800);
                        }
                        InfoChemTable(); return;

                    }//done
                    void CrdtChemTable()
                    {
                        Program p = new();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\n\t\tPERIODIC TABLE LINK:");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n\t\t\thttps://ascii.periodni.com");
                        Console.WriteLine("\n");
                        Console.WriteLine("\n\t\t\thttps://www.sigmaaldrich.com/PH/en/technical-documents/technical-article/chemistry-\n\t\t\tand-synthesis/organic-reaction-toolbox/periodic-table-of-elements-names");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\n\n\n\n\t\t[E]XIT");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(" ");
                        switch (p.iwasBackbottonhehe = Console.ReadLine())
                        {
                            case "e":
                                sciChemTable();
                                return;
                        }
                        if (p.iwasBackbottonhehe == "E")
                        {
                            sciChemTable();
                            return;
                        }
                        else
                        {
                            Console.Beep(700, 800);
                        }
                        CrdtChemTable(); return;
                    }//done

                    //Elements
                    void Hydrogen()
                    {
                        Program p = new();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\n\n");
                        Console.Write(@"
                      1     1.00784;1.00811
                      ██╗  ██╗        +1,-1
                      ██║  ██║        0.084
                      ███████║      -259.14
                      ██╔══██║      -252.87
                      ██║  ██║          2.1
                      ╚═╝  ╚═╝      13,5984
                      GAS          HYDROGEN
               ");
                        switch (p.iwasBackbottonhehe = Console.ReadLine())
                        {
                            case "e":
                                sciChemTable();
                                return;
                        }
                        if (p.iwasBackbottonhehe == "E")
                        {
                            sciChemTable();
                            return;
                        }
                        else
                        {
                            Console.Beep(700, 800);
                        }
                        Hydrogen(); return;



                    }
                    void Helium()
                    {
                        ScienceChemNoContent();
                    }
                    void Lithim()
                    {
                        ScienceChemNoContent();
                    }
                    void Beryllium()
                    {
                        ScienceChemNoContent();
                    }
                    void Boron()
                    {
                        ScienceChemNoContent();
                    }
                    void Carbon()
                    {
                        ScienceChemNoContent();
                    }
                    void Nitrogen()
                    {
                        ScienceChemNoContent();
                    }
                    void Oxygen()
                    {
                        ScienceChemNoContent();
                    }
                    void Flourione()
                    {
                        ScienceChemNoContent();
                    }
                    void Neo()
                    {
                        ScienceChemNoContent();
                    }
                    void Sodium()
                    {
                        ScienceChemNoContent();
                    }
                    void Magnesium()
                    {
                        ScienceChemNoContent();
                    }
                    void Aluminum()
                    {
                        ScienceChemNoContent();
                    }
                    void Silicon()
                    {
                        ScienceChemNoContent();
                    }
                    void Phosphorus()
                    {
                        ScienceChemNoContent();
                    }
                    void Sulfur()
                    {
                        ScienceChemNoContent();
                    }
                    void Chlorine()
                    {
                        ScienceChemNoContent();
                    }
                    void Argon()
                    {
                        ScienceChemNoContent();
                    }
                    void Potassium()
                    {
                        ScienceChemNoContent();
                    }
                    void Calcium()
                    {
                        ScienceChemNoContent();
                    }
                    void Scandium()
                    {
                        ScienceChemNoContent();
                    }
                    void Titanium()
                    {
                        ScienceChemNoContent();
                    }
                    void Vanadium()
                    {
                        ScienceChemNoContent();
                    }
                    void Chromium()
                    {
                        ScienceChemNoContent();
                    }
                    void Manganese()
                    {
                        ScienceChemNoContent();
                    }
                    void Iron()
                    {
                        ScienceChemNoContent();
                    }
                    void Cobalt()
                    {
                        ScienceChemNoContent();
                    }
                    void Nickel()
                    {
                        ScienceChemNoContent();
                    }
                    void Copper()
                    {
                        ScienceChemNoContent();
                    }
                    void Zinc()
                    {
                        ScienceChemNoContent();
                    }
                    void Gallium()
                    {
                        ScienceChemNoContent();
                    }
                    void Germanium()
                    {
                        ScienceChemNoContent();
                    }
                    void Arsenic()
                    {
                        ScienceChemNoContent();
                    }
                    void Selenium()
                    {
                        ScienceChemNoContent();
                    }
                    void Bromine()
                    {
                        ScienceChemNoContent();
                    }
                    void Krypton()
                    {
                        ScienceChemNoContent();
                    }
                    void Rubidium()
                    {
                        ScienceChemNoContent();
                    }
                    void Strontium()
                    {
                        ScienceChemNoContent();
                    }
                    void Yttrium()
                    {
                        ScienceChemNoContent();
                    }
                    void Zirconium()
                    {
                        ScienceChemNoContent();
                    }
                    void Niobium()
                    {
                        ScienceChemNoContent();
                    }
                    void Molybdenum()
                    {
                        ScienceChemNoContent();
                    }
                    void Technetium()
                    {
                        ScienceChemNoContent();
                    }
                    void Ruthenium()
                    {
                        ScienceChemNoContent();
                    }
                    void Rhodium()
                    {
                        ScienceChemNoContent();
                    }
                    void Palladium()
                    {
                        ScienceChemNoContent();
                    }
                    void Silver()
                    {
                        ScienceChemNoContent();
                    }
                    void Cadmium()
                    {
                        ScienceChemNoContent();
                    }
                    void Indium()
                    {
                        ScienceChemNoContent();
                    }
                    void Tin()
                    {
                        ScienceChemNoContent();
                    }
                    void Antimony()
                    {
                        ScienceChemNoContent();
                    }
                    void Tellurium()
                    {
                        ScienceChemNoContent();
                    }
                    void Iodine()
                    {
                        ScienceChemNoContent();
                    }
                    void Xenon()
                    {
                        ScienceChemNoContent();
                    }
                    void Cesium()
                    {
                        ScienceChemNoContent();
                    }
                    void Barium()
                    {
                        ScienceChemNoContent();
                    }
                    void Lanthanum()
                    {
                        ScienceChemNoContent();
                    }
                    void Cerium()
                    {
                        ScienceChemNoContent();
                    }
                    void Praseodymium()
                    {
                        ScienceChemNoContent();
                    }
                    void Neodymium()
                    {
                        ScienceChemNoContent();
                    }
                    void Promethium()
                    {
                        ScienceChemNoContent();
                    }
                    void Samarium()
                    {
                        ScienceChemNoContent();
                    }
                    void Europium()
                    {
                        ScienceChemNoContent();
                    }
                    void Gadolinium()
                    {
                        ScienceChemNoContent();
                    }
                    void Terbium()
                    {
                        ScienceChemNoContent();
                    }
                    void Dysprosium()
                    {
                        ScienceChemNoContent();
                    }
                    void Holmium()
                    {
                        ScienceChemNoContent();
                    }
                    void Erbium()
                    {
                        ScienceChemNoContent();
                    }
                    void Thullium()
                    {
                        ScienceChemNoContent();
                    }
                    void Ytterbium()
                    {
                        ScienceChemNoContent();
                    }
                    void Lutetium()
                    {
                        ScienceChemNoContent();
                    }
                    void Hafnium()
                    {
                        ScienceChemNoContent();
                    }
                    void Tantalum()
                    {
                        ScienceChemNoContent();
                    }
                    void Tungsten()
                    {
                        ScienceChemNoContent();
                    }
                    void Rhenium()
                    {
                        ScienceChemNoContent();
                    }
                    void Osmium()
                    {
                        ScienceChemNoContent();
                    }
                    void Iridium()
                    {
                        ScienceChemNoContent();
                    }
                    void Platinum()
                    {
                        ScienceChemNoContent();
                    }
                    void Gold()
                    {
                        ScienceChemNoContent();
                    }
                    void Mercury()
                    {
                        ScienceChemNoContent();
                    }
                    void Thallium()
                    {
                        ScienceChemNoContent();
                    }
                    void Lead()
                    {
                        ScienceChemNoContent();
                    }
                    void Bismuth()
                    {
                        ScienceChemNoContent();
                    }
                    void Polonium()
                    {
                        ScienceChemNoContent();
                    }
                    void Astatine()
                    {
                        ScienceChemNoContent();
                    }
                    void Radon()
                    {
                        ScienceChemNoContent();
                    }
                    void Francium()
                    {
                        ScienceChemNoContent();
                    }
                    void Radium()
                    {
                        ScienceChemNoContent();
                    }
                    void Actinium()
                    {
                        ScienceChemNoContent();
                    }
                    void Thorium()
                    {
                        ScienceChemNoContent();
                    }
                    void Protactinium()
                    {
                        ScienceChemNoContent();
                    }
                    void Uranium()
                    {
                        ScienceChemNoContent();
                    }
                    void Neptunium()
                    {
                        ScienceChemNoContent();
                    }
                    void Plutonium()
                    {
                        ScienceChemNoContent();
                    }
                    void Americium()
                    {
                        ScienceChemNoContent();
                    }
                    void Curium()
                    {
                        ScienceChemNoContent();
                    }
                    void Berkelium()
                    {
                        ScienceChemNoContent();
                    }
                    void Californium()
                    {
                        ScienceChemNoContent();
                    }
                    void Einsteinium()
                    {
                        ScienceChemNoContent();
                    }
                    void Fermium()
                    {
                        ScienceChemNoContent();
                    }
                    void Mendelevium()
                    {
                        ScienceChemNoContent();
                    }
                    void Nobelium()
                    {
                        ScienceChemNoContent();
                    }
                    void Lawrencium()
                    {
                        ScienceChemNoContent();
                    }
                    void Rutherfordium()
                    {
                        ScienceChemNoContent();
                    }
                    void Dubnium()
                    {
                        ScienceChemNoContent();
                    }
                    void Seaborgium()
                    {
                        ScienceChemNoContent();
                    }
                    void Bohrium()
                    {
                        ScienceChemNoContent();
                    }
                    void Hassium()
                    {
                        ScienceChemNoContent();
                    }
                    void Meitnerium()
                    {
                        ScienceChemNoContent();
                    }
                    void Darmstadtium()
                    {
                        ScienceChemNoContent();
                    }
                    void Reontgenium()
                    {
                        ScienceChemNoContent();
                    }
                    void Copernicium()
                    {
                        ScienceChemNoContent();
                    }
                    void Nihonium()
                    {
                        ScienceChemNoContent();
                    }
                    void Flerovium()
                    {
                        ScienceChemNoContent();
                    }
                    void Moscovium()
                    {
                        ScienceChemNoContent();
                    }
                    void Livermorium()
                    {
                        ScienceChemNoContent();
                    }
                    void Tennesine()
                    {
                        ScienceChemNoContent();
                    }
                    void Oganesson()
                    {
                        ScienceChemNoContent();
                    }











                }

            }//Onprogress








            void sciEcology()
            {
                ScienceNoContent();
            }//noinput
            void sciEconomy()
            {
                ScienceNoContent();
            }//noinput
            void sciGeography()
            {
                ScienceNoContent();
            }//noinput
            void sciLaws()
            {
                ScienceNoContent();
            }//noinput
            void sciLogic()
            {
                ScienceNoContent();
            }//noinput
            void sciMath()
            {
                ScienceNoContent();
            }//noinput
            void sciPhilosophy()
            {
                ScienceNoContent();
            }//noinput
            void sciPhysics()
            {
                ScienceNoContent();
            }//noinput
            void sciPsycology()
            {
                ScienceNoContent();

            }//noinput
            void sciSociology()
            {
                ScienceNoContent();
            }//noinput
            void sciStatistics()
            {
                ScienceNoContent();
            }//noinput





        } //on progress

        //History
        /// <summary>
        /// Nothing here
        /// </summary>
        //public static void History()
        //{
        //    Console.BackgroundColor = ConsoleColor.DarkGray;
        //    Console.Clear();
        //    Console.ForegroundColor = ConsoleColor.Black;
        //    Console.WriteLine("\n\n\n\n\t\t\t\t\t\t\t\t\tUNDER DEVELOPMENT :)");
        //    Console.ReadLine();

        //}


        private static void Minigames()
        {
            Program p = new();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t\t\t\tMINI GAMES");
            Console.WriteLine("\n\n\t\t\t\t[1] Tic-Tac-Toe");
            Console.WriteLine("\n\n\t\t\t\t[2] Snake");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\t\t\t\t(Unstable Version Be Advised!)");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\t\t\t\t[E]XIT");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\n\t\t\t\t ");
            switch (p.iwasBackbottonhehe = Console.ReadLine())
            {
                case "1":
                    Tictactoe();
                    return;
                case "2":
                    Snake();
                    return;
            }
            if (p.iwasBackbottonhehe == "e")
            {
                MainMenu();
            }
            if (p.iwasBackbottonhehe == "E")
            {
                MainMenu();
            }
            else
            {
                ;
            }
            Minigames(); return;




        } //Minigames Menu

        //ALL SNAKE START HERE

        static readonly int gridW = 90;
        static readonly int gridH = 25;
        static Cell[,] grid = new Cell[gridH, gridW];
        static Cell currentCell;
        static Cell food;
        static int FoodCount;
        static int direction; //0=Up 1=Right 2=Down 3=Left
        static readonly int speed = 1;
        static bool Populated = false;
        static bool Lost = false;
        static int snakeLength;

        public static void Snake()
        {
            if (!Populated)
            {
                FoodCount = 0;
                snakeLength = 5;
                populateGrid();
                currentCell = grid[(int)Math.Ceiling((double)gridH / 2), (int)Math.Ceiling((double)gridW / 2)];
                updatePos();
                addFood();
                Populated = true;
            }

            while (!Lost)
            {
                Restart();
            }
        }

        static void Restart()
        {
            Console.SetCursorPosition(0, 0);
            printGrid();
            Console.WriteLine("Length: {0}", snakeLength);
            getInput();
        }

        static void updateScreen()
        {
            Console.SetCursorPosition(0, 0);
            printGrid();
            Console.WriteLine("Length: {0}", snakeLength);
        }

        static void getInput()
        {

            //Console.Write("Where to move? [WASD] ");
            ConsoleKeyInfo input;
            while (!Console.KeyAvailable)
            {
                Move();
                updateScreen();
            }
            input = Console.ReadKey();
            doInput(input.KeyChar);
        }

        static void checkCell(Cell cell)
        {
            if (cell.val == "%")
            {
                eatFood();
            }
            if (cell.visited)
            {
                Lose();
            }
        }

        static void Lose()
        {
            Console.WriteLine("\n You lose!");
            Thread.Sleep(1000);
            Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
            Environment.Exit(-1);
        }

        static void doInput(char inp)
        {
            switch (inp)
            {
                case 'w':
                    goUp();
                    break;
                case 's':
                    goDown();
                    break;
                case 'a':
                    goRight();
                    break;
                case 'd':
                    goLeft();
                    break;
            }
        }

        static void addFood()
        {
            Random r = new Random();
            Cell cell;
            while (true)
            {
                cell = grid[r.Next(grid.GetLength(0)), r.Next(grid.GetLength(1))];
                if (cell.val == " ")
                    cell.val = "%";
                break;
            }
        }

        static void eatFood()
        {
            snakeLength += 1;
            addFood();
        }

        static void goUp()
        {
            if (direction == 2)
                return;
            direction = 0;
        }

        static void goRight()
        {
            if (direction == 3)
                return;
            direction = 1;
        }

        static void goDown()
        {
            if (direction == 0)
                return;
            direction = 2;
        }

        static void goLeft()
        {
            if (direction == 1)
                return;
            direction = 3;
        }

        static void Move()
        {
            if (direction == 0)
            {
                //up
                if (grid[currentCell.y - 1, currentCell.x].val == "*")
                {
                    Lose();
                    return;
                }
                visitCell(grid[currentCell.y - 1, currentCell.x]);
            }
            else if (direction == 1)
            {
                //right
                if (grid[currentCell.y, currentCell.x - 1].val == "*")
                {
                    Lose();
                    return;
                }
                visitCell(grid[currentCell.y, currentCell.x - 1]);
            }
            else if (direction == 2)
            {
                //down
                if (grid[currentCell.y + 1, currentCell.x].val == "*")
                {
                    Lose();
                    return;
                }
                visitCell(grid[currentCell.y + 1, currentCell.x]);
            }
            else if (direction == 3)
            {
                //left
                if (grid[currentCell.y, currentCell.x + 1].val == "*")
                {
                    Lose();
                    return;
                }
                visitCell(grid[currentCell.y, currentCell.x + 1]);
            }
            Thread.Sleep(speed * 100);
        }

        static void visitCell(Cell cell)
        {
            currentCell.val = "#";
            currentCell.visited = true;
            currentCell.decay = snakeLength;
            checkCell(cell);
            currentCell = cell;
            updatePos();

            //checkCell(currentCell);
        }

        static void updatePos()
        {

            currentCell.Set("@");
            if (direction == 0)
            {
                currentCell.val = "^";
            }
            else if (direction == 1)
            {
                currentCell.val = "<";
            }
            else if (direction == 2)
            {
                currentCell.val = "v";
            }
            else if (direction == 3)
            {
                currentCell.val = ">";
            }

            currentCell.visited = false;
            return;
        }

        static void populateGrid()
        {
            Random random = new Random();
            for (int col = 0; col < gridH; col++)
            {
                for (int row = 0; row < gridW; row++)
                {
                    Cell cell = new Cell();
                    cell.x = row;
                    cell.y = col;
                    cell.visited = false;
                    if (cell.x == 0 || cell.x > gridW - 2 || cell.y == 0 || cell.y > gridH - 2)
                        cell.Set("*");
                    else
                        cell.Clear();
                    grid[col, row] = cell;
                }
            }
        }

        static void printGrid()
        {
            string toPrint = "";
            for (int col = 0; col < gridH; col++)
            {
                for (int row = 0; row < gridW; row++)
                {
                    grid[col, row].decaySnake();
                    toPrint += grid[col, row].val;

                }
                toPrint += "\n";
            }
            Console.WriteLine(toPrint);
        }
        public class Cell
        {
            public string val
            {
                get;
                set;
            }
            public int x
            {
                get;
                set;
            }
            public int y
            {
                get;
                set;
            }
            public bool visited
            {
                get;
                set;
            }
            public int decay
            {
                get;
                set;
            }

            public void decaySnake()
            {
                decay -= 1;
                if (decay == 0)
                {
                    visited = false;
                    val = " ";
                }
            }

            public void Clear()
            {
                val = " ";
            }

            public void Set(string newVal)
            {
                val = newVal;
            }
        }

        /// <summary>
        /// ALL SNAKE PROGRAMM HEREMOSTLY How to move
        /// </summary>

        // tictactoe program start
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; //By default player 1 is set
        static int choice;     //This holds the choice at which position user want to mark
                               //The flag variable checks who has won if it's value is 1 then someone has won the match
                               //if -1 then Match has Draw if 0 then match is still running
                               //making array and
                               //by default I am providing 0-9 where no use of zero
        static int flag = 0;


        private static void Tictactoe()
        {
            do
            {
                Console.Clear();// whenever loop will be again start then screen will be clear
                Console.WriteLine("Player1:X and Player2:O");
                Console.WriteLine("\n");
                if (player % 2 == 0)//checking the chance of the player
                {
                    Console.WriteLine("Player 2 Chance");
                }
                else
                {
                    Console.WriteLine("Player 1 Chance");
                }
                Console.WriteLine("\n");
                Board();// calling the board Function
                choice = int.Parse(Console.ReadLine());//Taking users choice
                                                       // checking that position where user want to run is marked (with X or O) or not
                if (arr[choice] != 'X' && arr[choice] != 'O')



















                {
                    if (player % 2 == 0) //if chance is of player 2 then mark O else mark X
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else
                //If there is any possition where user want to run
                //and that is already marked then show message and load board again
                {
                    Console.WriteLine("         Sorry the row {0} is already marked with {1}", choice, arr[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("         Please wait 2 second board is loading again.....");
                    Thread.Sleep(2000);
                }
                flag = CheckWin();// calling of check win
            }
            while (flag != 1 && flag != -1);
            // This loop will be run until all cell of the grid is not marked
            //with X and O or some player is not win
            Console.Clear();// clearing the console
            Board();// getting filled board again
            if (flag == 1)
            // if flag value is 1 then someone has win or
            //means who played marked last time which has win
            {
                Console.WriteLine("         Player {0} has won", (player % 2) + 1);
                Console.WriteLine("         [E]XIT GAME");
            }
            else// if flag value is -1 the match will be draw and no one is winner
            {
                Console.WriteLine("         Draw");
                Console.WriteLine("         [E]XIT GAME");
            }
            Console.ReadLine();
        }
        // Board method which creats board
        static void Board()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("          _________________           ");
            Console.WriteLine("         |     |     |     |          ");
            Console.WriteLine("         |  {0}  |  {1}  |  {2}  |   Player 1 X       ", arr[1], arr[2], arr[3]);
            Console.WriteLine("         |_____|_____|_____|   Player 2 0       ");
            Console.WriteLine("         |     |     |     |          ");
            Console.WriteLine("         |  {0}  |  {1}  |  {2}  |          ", arr[4], arr[5], arr[6]);
            Console.WriteLine("         |_____|_____|_____|          ");
            Console.WriteLine("         |     |     |     |          ");
            Console.WriteLine("         |  {0}  |  {1}  |  {2}  |          ", arr[7], arr[8], arr[9]);
            Console.WriteLine("         |     |     |     |          ");
            Console.WriteLine("          \u0305\u0305\u0305\u0305\u0305\u0305\u0305\u0305\u0305\u0305\u0305\u0305\u0305\u0305\u0305\u0305\u0305         ");
            Console.Write("         Move: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("");
        }
        //Checking that any player has won or not
        static int CheckWin()
        {
            #region Horzontal Winning Condtion
            //Winning Condition For First Row
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            //Winning Condition For Second Row
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            //Winning Condition For Third Row
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            #endregion
            #region vertical Winning Condtion
            //Winning Condition For First Column
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            //Winning Condition For Second Column
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            //Winning Condition For Third Column
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            // If all the cells or values filled with X or O then any player has won the match
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }

        //tictactoe program end..

       

        //Future Project
        //public static void CMSOON()
        //{
        //    Console.BackgroundColor = ConsoleColor.DarkGray;
        //    Console.Clear();
        //    Console.ForegroundColor = ConsoleColor.Black;
        //    Console.WriteLine("\n\n\n\n\t\t\t\t\t\t\t\t\tUNDER DEVELOPMENT :)");
        //    Console.ReadLine();
        //}//nothing here...


        private static void EnglishDic() //english dictionary compilation 
        {
            Program p = new();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("[E]XIT");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(@"        
        ███████╗███╗   ██╗ ██████╗ ██╗     ██╗███████╗██╗  ██╗
        ██╔════╝████╗  ██║██╔════╝ ██║     ██║██╔════╝██║  ██║
        █████╗  ██╔██╗ ██║██║  ███╗██║     ██║███████╗███████║
        ██╔══╝  ██║╚██╗██║██║   ██║██║     ██║╚════██║██╔══██║
        ███████╗██║ ╚████║╚██████╔╝███████╗██║███████║██║  ██║
        ╚══════╝╚═╝  ╚═══╝ ╚═════╝ ╚══════╝╚═╝╚══════╝╚═╝  ╚═╝
");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n\n");
            Console.Write("\t\tSearch: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("");
            switch (p.iwasBackbottonhehe = Console.ReadLine())
            {
                //a
                case "a": case "A": case "Ah": case "ah": a(); return;
                case "abandon": case "Abandon": case "abandoned": case "Abandoned": abandon(); return;
                case "accessible": case "Accessible": accessible(); return;
                case "activate": case "Activate": activate(); return;
                case "antivirus": case "Antivirus": antivirus(); return;
                case "apple": case "Apple": case "Mansanas": case "mansanas": apple(); return;
                case "application": case "Application": application(); return;
                case "Apply": case "apply": apply(); return;
                case "archive": case "Archive": archive(); return;
                case "Arithmetic": case "arithmetic": arithmetic(); return;



                case "asshole": case "ass": case "Asshole": case "Ass": case "Ass Hole": case "ass hole": case "Anus": case "anus": case "anal": case "Anal": asshole(); return;





                //b
                case "backup": case "Backup": backup(); return;
                case "bag": case "Bag": bag(); return;
                case "ball": case "Ball": ball(); return;
                case "basket": case "Basket": basket(); return;
                case "Base": case "base": bbase(); return;
                case "binary": case "Binary": case "Gae": binary(); return;
                case "boat": case "Boat": boat(); return;
                case "bridge": case "Bridge": bridge(); return;
                case "bug": case "Bug": bug(); return;
                //c
                case "Cat": case "cat": case "Kitty": case "kitty": case "Kitten": case "kitten": case "Pusyy": case "pussy": cat(); return;
                case "car": case "Car": case "BroomBrooom": car(); return;
                case "Candy": case "candy": candy(); return;
                case "Color": case "color": color(); return;
                case "Custom": case "custom": custom(); return;
                case "Camera": case "camera": camera(); return;
                case "Combine": case "combine": combine(); return;
                case "Call": case "call": call(); return;
                case "Communication": case "communication": communication(); return;



                //d
                case "Drop": case "drop": drop(); return;
                case "Draft": case "draft": draft(); return;
                case "Divide": case "divide": divide(); return;
                case "Division": case "division": division(); return;
                case "debug": case "Debug": debug(); return;
                case "Dock": case "dock": dock(); return;
                case "Duck": case "duck": duck(); return;
                case "Drum": case "drum": drum(); return;


                //e
                case "Element": case "element": element(); return;
                case "end": case "End": end(); return;
                case "Everything": case "everything": everything(); return;
                case "economy": case "Economy": economy(); return;












                //f

                //g

                //h
                case "hello": case "Hello": case "hEllo": case "hi": case "Hi": case "hey": case "hoy": case "oy": case "ui": hello(); return;
                //i
                case "internet": case "Internet": case "www": internet(); return;
                //j

                //k

                //l
                case "Love": case "love": case "Loved": case "loving": case "sex": case "fuck": case "bonk": case "lovemaking": case "making love": case "planting seeds": case "erotic": case "sexual": case "beloved": case "dear": case "dearest": case "honey": case "horny": love(); return;
                //m

                //n
                case "Nanobot": case "nanobot": nanobot();return;
                   
                    
                case "Nanotechnology":
                    nanotechnology();
                    return;
                case "Net":
                    net();
                    return;
                case "Network":
                    network();
                    return;
                case "Nationalism":
                    nationalism();
                    return;
                case "Needle":
                    needle();
                    return;
                case "Nothing":
                    nothing();
                    return;
                //o
                case "Offer":
                    offer();
                    return;
                case "Obedient":
                    obedient();
                    return;
                case "Offensive":
                    offensive();
                    return;
                case "Online":
                    online();
                    return;
                case "Objective":
                    objective();
                    return;
                    //p

                    //q

                    //r

                    //s

                    //t

                    //u

                    //v

                    //w

                    //x

                    //y

                    //z


            }
            //switch(p.iwasBackbottonhehe = Console.ReadLine())
            if (p.iwasBackbottonhehe == "e")
            {
                MainMenu();
            }
            if (p.iwasBackbottonhehe == "E")
            {
                MainMenu();
            }
            else
            {
                ;
            }
            EngDicNoavailable(); return;

            void EngDicNoavailable()
            {
                Program p = new();
                Console.Beep(700, 800);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\n\n\n\n\t\t\t\t\tWORD NOT AVAILABLE :(");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("\n\t\t\t");

                switch (p.iwasBackbottonhehe = Console.ReadLine())
                {
                    case "E": EnglishDic(); return;
                }
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }

            //list here

            /*a*/
            void a()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tA:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/eɪ, ə/ /ə, eɪ/");

                Console.ForegroundColor = ConsoleColor.Blue;// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.WriteLine("\n\t\tAdjective:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. (chiefly, Scotland) All. [First attested from 1350 to 1470.]");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tAdverb:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. (chiefly, Scotland) All. [First attested from 1350 to 1470.]");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tArticle:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. One; any indefinite example of; used to denote a singular item of a group. [First \n\t\tattested prior to 1150]");
                Console.WriteLine("\t\t> There was a man here looking for you yesterday.");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. A meaningless syllable; ah.");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tLetter:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. The first letter of the English alphabet, called a and written in the Latin script.");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. The name of the Latin script letter A/a.");
                Console.WriteLine("\t\t2. A spoken sound represented by the letter a or A, as in map, mall, or male.");
                Console.WriteLine("\t\t3. A written representation of the letter A or a.");
                Console.WriteLine("\t\t4. A printer's type or stamp used to reproduce the letter a.");
                Console.WriteLine("\t\t5. An item having the shape of the letter a or A.");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tPreposition:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. (archaic) To do with position or direction; In, on, at, by, towards, onto. [First \n\t\tattested before 1150]");
                Console.WriteLine("\t\t> Stand a tiptoe.");
                Console.WriteLine("\t\t2. To do with separation; In, into. [First attested before 1150]");
                Console.WriteLine("\t\t> Torn a pieces.");
                Console.WriteLine("\t\t3. To do with time; Each, per, in, on, by. [First attested before 1150]");
                Console.WriteLine("\t\t> I brush my teeth twice a day.");
                Console.WriteLine("\t\t4. (obsolete) To do with method; In, with. [First attested before 1150]");
                Console.WriteLine("\t\t5. (obsolete) To do with role or capacity; In. [First attested before 1150]");
                Console.WriteLine("\t\t> A God’s name.");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tPronoun:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. (obsolete, except, UK, Scotland, dialectal) He. [1150-1900]");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tSymbol:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. (algebra) The first quantity, especially a constant, in an equation.");
                Console.WriteLine("\t\t> a^2+b^2=c^2"); Console.WriteLine("\t\t> ax^2+bx+c=0");
                Console.WriteLine("\t\t2. Distance from leading edge to aerodynamic center.");
                Console.WriteLine("\t\t3. specific absorption coefficient");
                Console.WriteLine("\t\t4. specific rotation");
                Console.WriteLine("\t\t5. allele (recessive)");
                Console.WriteLine("\t\t6. Designating a second residence with the same street number.");
                Console.WriteLine("\t\t> 12a Cromwell Street");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tVerb:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. (archaic or slang) Have. [between 1150 and 1350, continued in some use until 1650; \n\t\tused again after 1950]");
                Console.WriteLine("\t\t> I'd a come, if you'd a asked");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. From Middle English and Old English lower case letter a and split of Middle English \n\t\tand Old English lower case letter æ.");
                Console.WriteLine("\t\t2. Middle English, from Old English ān (“one, a, lone, sole”). The 'n' was gradually \n\t\tlost before consonants in almost all dialects by the 15th century.");
                Console.WriteLine("\t\t3. From Middle English a, ha contraction of have, or haven");
                Console.WriteLine("\t\t4. Variant spelling of ah.");
                Console.WriteLine("\t\t5. From Middle English (Northern dialect) aw, alteration of all.");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }

            void abandon()//word
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tAbandon:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/uh·ban·dn/ ");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. abandon; wantonness; unconstraint");
                Console.WriteLine("\t\tthe trait of lacking restraint or control; reckless freedom from inhibition \n\t\tor worry");
                Console.WriteLine("\t\t> she danced with abandon ");
                Console.WriteLine("\t\t2. wildness; abandon");
                Console.WriteLine("\t\ta feeling of extreme emotional intensity");
                Console.WriteLine("\t\t> the wildness of his anger  ");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tVerb:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. abandon");
                Console.WriteLine("\t\tforsake, leave behind");
                Console.WriteLine("\t\t> We abandoned the old car in the empty parking lot  ");
                Console.WriteLine("\t\t2. vacate; empty; abandon");
                Console.WriteLine("\t\tleave behind empty; move out of");
                Console.WriteLine("\t\t> You must vacate your office by tonight   ");
                Console.WriteLine("\t\t3. abandon; give up");
                Console.WriteLine("\t\tgive up with the intent of never claiming again");
                Console.WriteLine("\t\t> Abandon your life to God   ");
                Console.WriteLine("\t\t> She gave up her children to her ex-husband when she moved to Tahiti ");
                Console.WriteLine("\t\t> We gave the drowning victim up for dead ");
                Console.WriteLine("\t\t4. abandon; give up");
                Console.WriteLine("\t\tstop maintaining or insisting on; of ideas or claims");
                Console.WriteLine("\t\t> He abandoned the thought of asking for her hand in marriage ");
                Console.WriteLine("\t\t> Both sides have to give up some claims in these negotiations ");
                Console.WriteLine("\t\t5. abandon; forsake; desolate; desert");
                Console.WriteLine("\t\tleave someone who needs or counts on you; leave in the lurch");
                Console.WriteLine("\t\t> The mother deserted her children    ");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tAdverb:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. (obsolete, not comparable) Freely; entirely.");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. From French, from Old French abandon, from abondonner.");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }
            void accessible()
            {

                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tAccessible:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/ik-ˈse-sə-bəl , ak-, ek- /");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. capable of being reached.)");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\teasy to speak to or deal with.");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. capable of being understood or appreciated. ");
                Console.WriteLine("\t\tthe author's most accessible stories. ");
                Console.WriteLine("\t\t2. easily used or accessed by people with disabilities : adapted for use \n\t\tby people with disabilities");
                Console.WriteLine("\t\taccessible bathrooms/doorways/seating/parking");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  Middle English accessyble, borrowed from Middle French & Late Latin; \n\t\tMiddle French accessible, borrowed from Late Latin accessibilis, from Latin \n\t\taccessus (past participle of accēdere 'to approach') 15th Century.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }
            void activate()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tActivate:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/ak-tə-ˌvāt/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tVerb:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. to make (something, such as a molecule) reactive or more reactive");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\tto convert (something, such as a provitamin) into a biologically active \n\t\tderivative.");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. to treat (a substance, such as carbon or alumina) so as to improve ad\n\t\tsorptive properties ");
                Console.WriteLine("\t\tEven in Standard regen mode (High is available, too), there is no need to\n\t\t step into the soggy and soft brake pedal and activate the four-wheel discs.. ");
                Console.WriteLine("\t\t2. to set up or formally institute (an organized group, such as a military\n\t\t unit) with the necessary personnel and equipment");
                Console.WriteLine("\t\tTouch the screen to activate the system.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  probably as adaptation of French activer, going back to Middle French,\n\t\t derivative of actif First Known Use of activate 1624.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }
            void antivirus()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tAntivirus:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/an-tē-ˈvī-rəs , ˌan-tī-/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tAdjective:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. used to protect a computer from viruses : ANTIVIRAL");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\tmedical : acting, effective, or directed against viruses : ANTIVIRAL");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. antivirus software ");
                Console.WriteLine("\t\t2. an antivirus vaccin");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  First Known Use of Antivirus 1892.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }
            void apple()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tApple:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/ˈa-pəl/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. the fleshy, usually rounded red, yellow, or green edible pome fruit of \n\t\ta usually cultivated tree (genus Malus) of the rose family");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\ta fruit (such as a star apple) or other vegetative growth (such as an oak \n\t\tapple) suggestive of an apple.");//explanation

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. First Known Use of apple before the 12th century, Middle English appel, from \n\t\tOld English æppel; akin to Old High German apful apple, Old Irish ubull, Old \n\t\tChurch Slavonic ablŭko.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;

            }
            void application()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tApplication:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/a-plə-ˈkā-shən/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. a formal and usually written request for something (such as a job, admission \n\t\tto a school, a loan, etc.)");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\ta document that is used to make a formal request for something.");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. the act of putting something on a surface, a part of the body, etc. ");
                Console.WriteLine("\t\tThe application of heat often helps sore muscles. ");
                Console.WriteLine("\t\t2.  an act of putting something to use ");
                Console.WriteLine("\t\tapplication of new techniques");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  Middle English applicacioun, from Latin application-, applicatio inclination, \n\t\tfrom applicare (14th Century).");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }

            void apply()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tApply:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/ə-ˈplī/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. to put to use especially for some practical purpose.");
                Console.WriteLine("\t\tHe applies pressure to get what he wants..");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. to bring into action.");
                Console.WriteLine("\t\t~apply the brakes.");
                Console.WriteLine("\t\t2. to lay or spread on.");
                Console.WriteLine("\t\t~apply varnish");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. First Known Use of apply 14th century, Middle English applien, from \n\t\tAnglo-French aplier, from Latin applicare, from ad- + plicare to fold — more at PLY.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }
            void archive()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tArchive :");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/ˈär-ˌkīv/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.a place in which public records or historical materials (such as \n\t\tdocuments) are preserved");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\talso : the material preserved —often used in plural");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. a repository or collection especially of information");
                Console.WriteLine("\t\tarchived tissue samples ");
                Console.WriteLine("\t\t2. to file or collect in or as if in an archive");
                Console.WriteLine("\t\tarchive documents ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  First Known Use of Archive 1603.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }
            void arithmetic()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tArithmetic:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/ə-ˈrith-mə-ˌtik/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. COMPUTATION, CALCULATION");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\ta branch of mathematics that deals usually with the nonnegative real numbers \n\t\tincluding sometimes tthe transfinite cardinals and with the application \n\t\tof the operations of addition, subtraction, multiplication, and division to them.");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. a treatise on arithmetic.");
                Console.WriteLine("\t\t~a software program that will do the arithmetic for you.");
                Console.WriteLine("\t\t2. ");
                Console.WriteLine("\t\t ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. First Known Use of arithmetic 15th century, Middle English arsmetrik, from \n\t\tAnglo-French arismatike, from Latin arithmetica, from Greek arithmētikē, \n\t\tfrom feminine of arithmētikos arithmetical, from arithmein to count, from arithmos \n\t\tnumber; akin to Old English rīm number, and perhaps to Greek arariskein to fit.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;

            }

            void asshole()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tAsshole:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/ˈæsˌhoʊl/ ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. arse; arsehole; asshole; bunghole");
                Console.WriteLine("\t\t> vulgar slang for anus");
                Console.WriteLine("\t\t2. asshole; bastard; cocksucker; dickhead; shit; mother fucker; motherfuck\n\t\ter; prick; whoreson; son of a bitch; SOB");
                Console.WriteLine("\t\t> insulting terms of address for people who are stupid or irritating or rid\n\t\ticulous ");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. Variation of earlier arsehole, from Middle English arshole, arcehoole, eq\n\t\tuivalent to ass + hole. Cognate with Norwegian rasshøl (“asshole”), Swedish arsle (“asshole”).\n\t\t Compare also German Arschloch (“asshole”). Attested from the 1370s, replacing earlier \n\t\tOld English earsþerl (“anus”, literally “arse thirl”). First recorded in Middle English, as \n\t\ters hole (Glouc. Cath. Manuscript 19. No. I. , dated 1379, cited after OED), ars-hole \n\t\t(Bodleian Ashmole MS. 1396, dated ca. 1400, ed. Robert Von Fleischhacker as Lanfrank's 'Science of \n\t\tCirurgie', EETS 102, 1894, cited after OED.)");
                Console.WriteLine("\t\t2. Slang figurative usage dates to the 20th century, of an uninviting place \n\t\t(c.f. shithole) in the 1920s, of an anti-social or despicable person from at least the 1950s \n\t\t(Harvard Advocate 137, March 1954), also appositionally (as in 'You're an asshole moralist\n\t\t', T. Chamales 1957)");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }
            /*b*/
            void backup()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tBackup:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/bak-ˌəp/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. one that serves as a substitute or support");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\ta copy of computer data (such as a file or the contents of a hard drive)");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.additional personnel who provide assistance ");
                Console.WriteLine("\t\tThe police officer called for backup. ");
                Console.WriteLine("\t\t2 musical accompaniment ");
                Console.WriteLine("\t\tThe tunes include banjo and guitar backup. ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  First Known Use of backup 1910 Century.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;

            }
            void bag()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tBag:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/bag  also ˈbāg  /");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. a usually flexible container that may be closed for holding, storing, or \n\t\tcarrying something: such as");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\tsomething resembling a bag");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.a pouched or pendulous bodily part or organ especially : UDDER ");
                Console.WriteLine("\t\ta puffy or sagging protuberance of flabby skin ");
                Console.WriteLine("\t\t2. the amount contained in a bag ");
                Console.WriteLine("\t\ta quantity of game taken also : the maximum legal quantity of game ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  First Known Use of bag 13th century, Middle English bagge, from Old Norse \n\t\tbaggi.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;

            }

            void ball()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tBall:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/bȯl /");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun, often attribue:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. a round or roundish body or mass: such as");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\ta spherical or ovoid body used in a game or sport");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.used figuratively in phrases like the ball is in your court to indicate who has \n\t\tthe responsibility or opportunity for further action ");
                Console.WriteLine("\t\ta spherical or conical projectile ");
                Console.WriteLine("\t\t2. also : projectiles used in firearms ");
                Console.WriteLine("\t\ta roundish protuberant anatomical structure (as near the tip of a human finger or \n\t\ttoe or at the base of a thumb) ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  First Known Use of ball 13th century.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;

            }
            void bbase()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tBase:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/bā-​səz/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. the bottom or lowest part of something : the part on which something rests \n\t\tor is supported");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\ta main ingredient to which other things are added to make something");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. the bottom of something considered as its support : FOUNDATION ");
                Console.WriteLine("\t\tthe base of the mountain ");
                Console.WriteLine("\t\t2. biology : that part of a bodily organ by which it is attached to another more \n\t\tcentral structure of the organism ");
                Console.WriteLine("\t\tthe base of the thumb ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  First Known Use of base 14th century, Middle English, from Anglo-French, from \n\t\tLatin basis, from Greek, step, base, from bainein to go.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }

            void basket()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tBasket:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/bak-ˌəp/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. something that resembles a basket especially in shape or use");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\ta receptacle made of interwoven material (such as osiers))");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. any of various lightweight usually wood containers ");
                Console.WriteLine("\t\tThey brought their lunch in a picnic basket.. ");
                Console.WriteLine("\t\t2 a net open at the bottom and suspended from a metal ring that constitutes the \n\t\tgoal in basketball ");
                Console.WriteLine("\t\tHis shot missed the basket completely. ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  First Known Use of basket 13th century, Middle English, from Anglo-French; \n\t\takin to Old French baschoue wooden vessel; both from Latin bascauda kind of basin, of \n\t\tCeltic origin; akin to Middle Irish basc necklace.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }
            void binary()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tBinary:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/bī-nə-rē  , -ˌner-ē  , -ˌne-rē/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. mathematics : a number system based only on the numerals 0 and 1 : a binary \n\t\t(see BINARY entry 2 sense 3a) number system");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\ta division into two groups or classes that are considered diametrically opposite");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.compounded or consisting of or marked by two things or parts ");
                Console.WriteLine("\t\t2. mathematics : relating to, being, or belonging to a system of numbers having \n\t\t2 as its base  ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  First Known Use of binary 15th century.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }
            void boat()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tBoat:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/bōt/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. a small vessel for travel on water");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\ta boat-shaped container, utensil, or device");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. informal : a large car");
                Console.WriteLine("\t\tA lot of people still think Cadillac makes big floaty boats.  ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  First Known Use of boat before the 12th century.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }
            void bridge()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tBridge:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/brij/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. a structure carrying a pathway or roadway over a depression or obstacle (su\n\t\tch as a river)");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\ta time, place, or means of connection or transition");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. something resembling a bridge in form or function: such as: the upper bony \n\t\tpart of the nose.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. First Known Use of bridge before the 12th century, Middle English brigge, from \n\t\tOld English brycg; akin to Old High German brucka bridge, Old Church \n\t\tSlavonic brŭvŭno beam.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;

            }
            void bug()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tBug:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/bəg/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. any of various small arthropods (such as a beetle or spider) resembling the \n\t\ttrue bugs");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\tany of several insects (such as a head louse) commonly considered obnoxious");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. an unexpected defect, fault, flaw, or imperfection ");
                Console.WriteLine("\t\t\the software was full of bugs ");
                Console.WriteLine("\t\t2. a microorganism (such as a bacterium or virus) especially when causing illness \n\t\tor disease ");
                Console.WriteLine("\t\ta stomach bug ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  First Known Use of bug 1594.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;

            }

            /*c*/
            void call()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tCall: ");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/kȯl/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tVerb: called; calling; calls");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  to speak in a loud voice");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t: to announce or read (something) in a loud voice");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: to generate signals for (a telephone number) in order to reach the party to whom the number is assigned");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. to speak to or attempt to reach someone by means of a call ");
                Console.WriteLine("\t\t to make a demand in card games (as for a particular card or for a show of hands)");
                Console.WriteLine("\t\t2 : to utter in a loud distinct voice —often used with out");
                Console.WriteLine("\t\t to announce or read loudly or authoritatively");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  First Known Use of call before the 12th century, Middle English, from Old Norse kalla; akin to Old English hildecalla battle herald, Old High German kallōn to talk loudly, Old Church Slavonic glasŭ voice");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }//case
            void camera()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tCamera:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/kam-rə , ˈka-mə-rə/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tVerb:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. the treasury department of the papal curia");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\tlong-established practice considered as unwritten law");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: a device that consists of a lightproof chamber with an aperture fitted with a lens and a shutter through which the image of an object is projected onto a surface for recording (as on a photosensitive film or an electronic sensor) or for translation into electrical impulses (as for television broadcast) ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. off camera: while not being filmed by a television or movie camera");
                Console.WriteLine("\t\t: outside the scope of a television or movie camera");
                Console.WriteLine("\t\t2. on camera: before a live television camera");
                Console.WriteLine("\t\t: within the scope of a television or movie camera ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  First Known Use of camera 1566, Late Latin, room");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }//case

            void candy()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tCandy:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/kan-dē/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. crystallized sugar formed by boiling down sugar syrup");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\tsomething that is pleasant or appealing in a light or frivolous way");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection:  ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. a confection made with sugar and often flavoring and filling");
                Console.WriteLine("\t\t\a piece of such confection ");
                Console.WriteLine("\t\t2. to encrust in or coat with sugar");
                Console.WriteLine("\t\tspecifically : to cook (something, such as fruit or fruit peel) in a heavy syrup until glazed ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  First Known Use of candy 1587, Middle English sugre candy, partial translation of Middle French sucre candi, from Old French sucre sugar + Arabic qandī candied, from qand crystallized sugar");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }//case
            void cat()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tCat:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/kat/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun, often attribute:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. a carnivorous mammal (Felis catus) long domesticated as a pet and for catching rats and mice");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\tany of a family (Felidae) of carnivorous usually solitary and nocturnal mamm\n\t\tals (such as the domestic cat, lion, tiger, leopard, jaguar, cougar, \n\t\twildcat, lynx, and cheetah)");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. a malicious woman");
                Console.WriteLine("\t\tespecially : one given to making catty remarks about other women ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  First Known Use of cat before the 12th century, Middle English, from Old \n\t\tEnglish catt, probably from Late Latin cattus, catta cat.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }
            void car()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tCar:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/kär, dialectal also ˈkȯr, ˈkyär/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. a vehicle moving on wheels");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\ta vehicle designed to move on rails (as of a railroad)");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. the passenger compartment of an elevator");
                Console.WriteLine("\t\tthe part of an airship or balloon that carries the passengers and cargo ");
                Console.WriteLine("\t\t2 The train has 20 cars. ");
                Console.WriteLine("\t\ttraveled to Boston by car ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  First Known Use of car 14th century,Middle English carre 'cart, wagon, small cartload, ' \n\t\tborrowed from Anglo-French carre, charre, going back to Latin carra, plural of \n\t\tcarrum, neuter variant of carrus 'a kind of Gaulish wagon, ' borrowed from the Gaulish \n\t\toutcome of Celtic *kr̥s-o-, whence also Old Irish carr 'cart, wagon, ' Welsh car 'vehicle");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }
            void color()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tColor:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/ˈkə-lər/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun, often Attribute:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. a quality such as red, blue, green, yellow, etc., that you see when you look at something");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\ta phenomenon of light (such as red, brown, pink, or gray) or visual perception that enables one to differentiate otherwise identical objects");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: to fill in a shape or picture outlined on a piece of paper using markers, crayons, colored pencils, etc. ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. a color other than and as contrasted with black, white, or gray");
                Console.WriteLine("\t\tsomething used to give color : PIGMENT ");
                Console.WriteLine("\t\t2. the use or combination of colors");
                Console.WriteLine("\t\tskin pigmentation other than and especially darker than what is considered characteristic of people typically defined as white ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  First Known Use of color 14th century, Middle English colour, borrowed from Anglo-French, going back to Latin color, earlier colōs 'color as a physical phenomenon, pigment, complexion, appearance, ' probably, assuming an original meaning 'covering, outermost layer, appearance, '' going back to *ḱel-ōs, collective derivative from an Indo-European s-stem *ḱel-os 'covering' (whence perhaps Sanskrit śaras- 'skin on boiled milk, cream' and, from a thematic derivative, Old High German hulisa 'hull of a legume'), derivative of a verbal base *ḱel- 'cover, conceal' — more at CONCEAL");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }//case
            void combine()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tCombine: ");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/ kəm-ˈbīn /");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tVerb: combined; combining");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. to bring into such close relationship as to obscure individual characters : MERGE");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t: to cause to unite into a chemical compound");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: an event at which scouts from the teams in a professional sports league gather to evaluate players in preparation for choosing which players to draft ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. to unite into a single number or expression");
                Console.WriteLine("\t\t: to possess in combination");
                Console.WriteLine("\t\t2 to unite to form a chemical compound");
                Console.WriteLine("\t\t: to act together ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  First Known Use of combine 15th century, Middle English, from Middle French combiner, from Late Latin combinare, from Latin com- + bini two by two");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }//case
            void communication()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tCommunication: ");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/kə-ˌmyü-nə-ˈkā-shən/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. : the act or process of using words, sounds, signs, or behaviors to express or exchange information or to express your ideas, thoughts, feelings, etc., to someone else");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t formal : a message that is given to someone : a letter, telephone call, etc.");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: a process by which information is exchanged between individuals through a common system of symbols, signs, or behavior");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. information communicated : information transmitted or conveyed");
                Console.WriteLine("\t\t a verbal or written message");
                Console.WriteLine("\t\t2 : a system (as of telephones or computers) for transmitting or exchanging information");
                Console.WriteLine("\t\t a system of routes for moving troops, supplies, and vehicles");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  First Known Use of communication 14th century");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }//case

            void custom()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tCustom:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/kə-stəm/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. a usage or practice common to many or to a particular place or class or habitual with an individual");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\tlong-established practice considered as unwritten law");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: the whole body of usages, practices, or conventions that regulate social life ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. long-established practice considered as unwritten law");
                Console.WriteLine("\t\tduties, tolls, or imposts imposed by the sovereign law of a country on imports or exports");
                Console.WriteLine("\t\t2. usually singular in construction : the agency, establishment, or procedure for collecting such customs");
                Console.WriteLine("\t\tmade or performed according to personal order ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  First Known Use of custom 1757, Middle English custume, from Anglo-French, from Latin consuetudin-, consuetudo, from consuescere to accustom, from com- + suescere to accustom; akin to suus one's own");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }//case

            /*d*/
            void debug()//case
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tDebug: ");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/de·​bug | / (ˌ)dē-ˈbəg /");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tVerb: debugged; debugging; debugs");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. to remove insects from");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t to eliminate errors in or malfunctions of");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection:");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. to remove a concealed microphone or wiretapping device from");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. First Known Use of debug 1944");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }
            void divide()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tDivide: ");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/di·​vide | \\ də-ˈvīd/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tVerb: divided; dividing");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  to separate into two or more parts, areas, or groups");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t to separate into classes, categories, or divisions");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: to subject (a number or quantity) to the operation of finding how many times it contains another number or quantity");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. to separate into portions and give out in shares : DISTRIBUTE");
                Console.WriteLine("\t\t to possess, enjoy, or make use of in common");
                Console.WriteLine("\t\t2. to cause to be separate, distinct, or apart from one another");
                Console.WriteLine("\t\t to separate into opposing sides or parties");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  First Known Use of divide 14th century, Middle English, from Latin dividere, from dis- + -videre to separate ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }//case
            void division()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tDivition: ");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/di·​vi·​sion | / də-ˈvi-zhən/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. the act or process of dividing : the state of being divided");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t the act, process, or an instance of distributing among a number : DISTRIBUTION");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: the physical separation into different lobbies of the members of a parliamentary body voting for and against a question");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. one of the parts or groupings into which a whole is divided or is divisible");
                Console.WriteLine("\t\t something that divides, separates, or marks off");
                Console.WriteLine("\t\t2. the act, process, or an instance of separating or keeping apart : SEPARATION");
                Console.WriteLine("\t\t the mathematical operation of dividing something");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. First Known Use of division 14th century, Middle English, from Anglo-French devision, from Latin division-, divisio, from dividere to divide");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }//case
            void dock()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tDock: ");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/däk/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. a place (such as a wharf or platform) for the loading or unloading of materials");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t a usually wooden pier used as a landing place or moorage for boats");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: a usually artificial basin or enclosure for the reception of ships that is equipped with means for controlling the water height");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. the combining site of a molecular receptor");
                Console.WriteLine("\t\t to haul or guide into or alongside a dock ");
                Console.WriteLine("\t\t2. to connect an electronic device (such as a computer or a digital camera) to another device ");
                Console.WriteLine("\t\t  to join (two spacecraft) mechanically while in space");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. First Known Use of dock 15th century, Middle English dok, perhaps from Old English -docca (as in fingirdocca finger muscle); akin to Old High German tocka doll, Old Norse dokka bundle");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }//case
            void draft()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tDraft: ");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/draft, ˈdräft/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\t Noun");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. : a version of something (such as a document) that you make before you make the final version");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t cool air moving in a closed space (such as a room)");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: a system in which young people are required to join the armed forces of a country for a period of service");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. the act of drawing or pulling in a net");
                Console.WriteLine("\t\t  the act or an instance of drinking or inhaling");
                Console.WriteLine("\t\t2 : also : the portion drunk or inhaled in one such act");
                Console.WriteLine("\t\t a portion poured out or mixed for drinking : DOSE");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  First Known Use of draft 13th century, Middle English draght; akin to Old English dragan to draw");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }//case 

            void drop()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tDrop: ");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/dräp/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\t Noun, often attributive");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  the quantity of fluid that falls in one spherical mass");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t drops plural : a dose of medicine measured by drops");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: the act or an instance of dropping : FALL");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. a minute quantity or degree of something nonmaterial or intangible ");
                Console.WriteLine("\t\t the smallest practical unit of liquid measure");
                Console.WriteLine("\t\t2. a decline in quantity or quality");
                Console.WriteLine("\t\t the distance from a higher to a lower level or through which something drops");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  First Known Use of drop before the 12th century, Middle English, from Old English dropa; akin to Old High German tropfo drop");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }//case
            void drum()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tDrum: ");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/drəm/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. a percussion instrument consisting of a hollow shell or cylinder with a drumhead stretched over one or both ends that is beaten with the hands or with some implement (such as a stick or wire brush)");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t the sound of a drum");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: any of various chiefly marine bony fishes (family Sciaenidae) that make a drumming or croaking noise using their air bladder and associated muscles");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. any of various chiefly marine bony fishes (family Sciaenidae) that make a drumming or croaking noise using their air bladder and associated muscles");
                Console.WriteLine("\t\t a cylindrical machine or mechanical device or part");
                Console.WriteLine("\t\t2. something resembling a drum in shape: such as ");
                Console.WriteLine("\t\t any of the cylindrical blocks that form the shaft of a column ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. First Known Use of drum circa 1534, probably from Dutch trom; akin to Middle High German trumme drum");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }//case
            void duck()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tDuck: ");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/dək/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun, often Attribute");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. any of various swimming birds (family Anatidae, the duck family) in which the neck and legs are short, the feet typically webbed, the bill often broad and flat, and the sexes usually different from each other in plumage —often used figuratively in phrases like have one's ducks in a row, get one's ducks in a row, or put one's ducks in a row to describe being or becoming thoroughly prepared or organized");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t the flesh of any of these birds used as food");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection:");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. an instance of ducking");
                Console.WriteLine("\t\t a durable closely woven usually cotton fabric");
                Console.WriteLine("\t\t2. ducks plural : light clothes and especially trousers made of duck ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. First Known Use of duck before the 12th century, Middle English duk, doke, from Old English dūce Verb");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }//case

            /*E*/
            void economy()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tEconomy: ");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/i-ˈkä-nə-mē , ə-, ē-/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. : the process or system by which goods and services are produced, sold, and bought in a country or region");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t careful use of money, resources, etc.");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: the structure or conditions of economic life in a country, area, or periodalso an economic system");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. thrifty and efficient use of material resources : frugality in expenditures");
                Console.WriteLine("\t\t also : an instance or a means of economizing : SAVING");
                Console.WriteLine("\t\t2. the arrangement or mode of operation of something : ORGANIZATION ");
                Console.WriteLine("\t\t a system especially of interaction and exchange  ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. First Known Use of economy 1821, Middle French yconomie, from Medieval Latin oeconomia, from Greek oikonomia, from oikonomos household manager, from oikos house + nemein to manage");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }//case
            void element()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tElement: ");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/ˈe-lə-mənt/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. chemistry : one of the basic substances that are made of atoms of only one kind and that cannot be separated by ordinary chemical means into simpler substances");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t a particular part of something (such as a situation or activity)");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: any of the four substances air, water, fire, and earth formerly believed to compose the physical universe");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. a part of an electrical device that produces heat");
                Console.WriteLine("\t\t the state or sphere natural or suited to a person or thing");
                Console.WriteLine("\t\t2. a constituent part: such as ");
                Console.WriteLine("\t\t elements plural : the simplest principles of a subject of study : RUDIMENTS ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. First Known Use of element 13th century, Middle English, from Anglo-French & Latin; Anglo-French, from Latin elementum");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }//case
            void end()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tEnd: ");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/end/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. the part of an area that lies at the boundary");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t the terminal unit of something spatial that is marked off by units");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: a period of action or turn in any of various sports events (such as archery or lawn bowling)");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. cessation of a course of action, pursuit, or activity");
                Console.WriteLine("\t\t the ultimate state");
                Console.WriteLine("\t\t2. something incomplete, fragmentary, or undersized ");
                Console.WriteLine("\t\t an outcome worked toward : PURPOSE ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.First Known Use of end before the 12th century, Middle English ende, from Old English; akin to Old High German enti end, Latin ante before, Greek anti against");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }//case


            void everything()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tEverything: ");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/ev·​ery·​thing |  ˈev-rē-ˌthiŋ /");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tPronoun");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. all that exists");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t all that relates to the subject");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: all sorts of other things —used to indicate related but unspecified events, facts, or conditions)");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. all that is important");
                Console.WriteLine("\t\t having a mixture of toppings");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. First Known Use of everything 13th century");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }//case



            /*h*/
            void hello()//papalitan nyo yung salitang naka sunod sa satitic void example "hi" tapos proceed kayo next procedure.
                        //lower case pala lahat ne?
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tHello:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/həˈloʊ, heˈloʊ/ /həˈləʊ, he-/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. hello; hullo; hi; howdy; how-do-you-do");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\tan expression of greeting");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. A greeting (salutation) said when meeting someone or acknowledging someone’s arrival or presence.");
                Console.WriteLine("\t\t~Hello, everyone.");
                Console.WriteLine("\n\t\t2. A greeting used when answering the telephone.");
                Console.WriteLine("\t\t~Hello? How may I help you?");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. Hello (first attested in 1846) from hallo (attested 1840), from holla,hollo (attested 1588).\n\t\tThis variant of hallo is often credited to Thomas Edison as a coinage for telephone use but \n\t\tits appearance in print predates the invention of the telephone by several decades.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }
            /*I*/
            void internet()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tInternet: ");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/in-tər-ˌnet/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. an electronic communications network that connects computer networks and organizational computer facilities around the world —used with the except when being used attributively");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\n\t\tNOTE: In U.S. publications, the capitalized form Internet continues to be more common than internet, although the lowercase form is rapidly gaining more widespread use. In British publications, internet is now the more common form.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. First Known Use of Internet 1986");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }
            /*l*/
            void love()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tLove:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/ləv/ /lʌv/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");
                // lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. love");//example or pano pasya pwede gamitin
                Console.WriteLine("\t\ta strong positive emotion of regard and affection");//explanation
                Console.WriteLine("\t\t> his love for his work ");
                Console.WriteLine("\t\t> children need a lot of love ");
                Console.WriteLine("\n\t\t2. love; passion");//example or pano pasya pwede gamitin
                Console.WriteLine("\t\tany object of warm affection or devotion");//explanation
                Console.WriteLine("\t\t> the theater was her first love ");
                Console.WriteLine("\t\t> he has a passion for cock fighting ");
                Console.WriteLine("\n\t\t3. beloved; dear; dearest; honey; love");//example or pano pasya pwede gamitin
                Console.WriteLine("\t\ta beloved person; used as terms of endearment ");//explanation
                Console.WriteLine("\n\t\t4. love; sexual love; erotic love");//example or pano pasya pwede gamitin
                Console.WriteLine("\t\ta deep feeling of sexual desire and attraction");//explanation
                Console.WriteLine("\t\t> their love left them indifferent to their surroundings ");
                Console.WriteLine("\t\t> she was his first love ");
                Console.WriteLine("\n\t\t5. sexual love; lovemaking; making love; love; love life");//example or pano pasya pwede gamitin
                Console.WriteLine("\t\tsexual activities (often including sexual intercourse) between two people ");//explanation
                Console.WriteLine("\t\t> his lovemaking disgusted her ");
                Console.WriteLine("\t\t> he hadn't had any love in months ");
                Console.WriteLine("\t\t> he has a very complicated love life ");
                Console.WriteLine("\n\t\t6. love");
                Console.WriteLine("\t\ta score of zero in tennis or squash");
                Console.WriteLine("\t\t> it was 40 love ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tVerb:");
                // lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. love");//example or pano pasya pwede gamitin
                Console.WriteLine("\t\thave a great affection or liking for");//explanation
                Console.WriteLine("\t\t> I love French food ");
                Console.WriteLine("\t\t> She loves her boss and works hard for him ");
                Console.WriteLine("\n\t\t2. love; enjoy");//example or pano pasya pwede gamitin
                Console.WriteLine("\t\tget pleasure from");//explanation
                Console.WriteLine("\t\t> I love cooking ");
                Console.WriteLine("\n\t\t3. love");//example or pano pasya pwede gamitin
                Console.WriteLine("\t\tbe enamored or in love with ");//explanation
                Console.WriteLine("\t\t> She loves her husband deeply ");
                Console.WriteLine("\n\t\t4. sleep together; roll in the hay; love; make out; make love; sleep with; get laid; \n\t\thave sex; know; do it; be intimate; have intercourse; have it away; have it off; screw;\n\t\tfuck; jazz; eff; hump; lie with; bed; have a go at it; bang; get it on; bonk");//example or pano pasya pwede gamitin
                Console.WriteLine("\t\thave sexual intercourse with");//explanation
                Console.WriteLine("\t\t> This student sleeps with everyone in her dorm ");
                Console.WriteLine("\t\t> Adam knew Eve  ");
                Console.WriteLine("\t\t> Were you ever intimate with this man?");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. From Middle English love, luve, from Old English lufu (“love, affection, desire”), \n\t\tfrom Proto-Germanic *lubō (“love”), from Proto-Indo-European *lewbʰ-, *leubʰ- (“love,  \n\t\tcare, desire”). Cognate with Old Frisian luve (“love”), Old High German luba (“love”). \n\t\tRelated to Old English lēof (“dear, beloved”), līefan (“to allow, approve of”), \n\t\tLatin libet, lubō (“to please”) and Albanian lyp (“to beg, ask insistently”), lips \n\t\t(“to be demanded, needed”), Serbo-Croatian ljubiti, ljubav, Russian любовь, любить.");
                Console.WriteLine("\n\t\t2. From Middle English loven, lovien, from Old English lufian (“to love, cherish, \n\t\tsow love to; fondle, caress; delight in, approve, practice”), from the noun lufu (“love”).\n\t\tSee above. Compare West Frisian leavje (“to love”), German lieben (“to love”).");
                Console.WriteLine("\n\t\t3. From Middle English loven, lovien, from Old English lofian (“to praise, exalt, \n\t\tappraise, value”), from Proto-Germanic *lubōną (“to praise, vow”), from *lubą (“praise”), \n\t\tfrom Proto-Indo-European *leubʰ- (“to like, love, desire”), *lewbʰ-. Cognate with Scots \n\t\tlove, lofe (“to praise, honour, esteem”), Dutch loven (“to praise”), German \n\t\tloben (“to praise”), Swedish lova (“to promise, pledge”), Icelandic lofa (“to promise”). \n\t\tSee also lofe.");
                Console.WriteLine("\n\t\t4. From the phrase Neither for love nor for money, meaning 'nothing'. The \n\t\tpreviously held belief that it originated from the French term l’œuf (“the egg”), due to its shape,\n\t\tis no longer widely accepted.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }

            //n
            void nanobot()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tNanobot:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/nano·​bot |  ˈna-nō-ˌbät/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. are robots made of nanomaterials that can carry out tasks");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t(robotics) A very small autonomous robot, typically the size of a biological cell, designed to work alone or in very large numbers to achieve some task.  Not yet in practical use.");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection:  ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. a microscopically small robot : a robot built on the scale of nanometers.");
                Console.WriteLine("\t\tAnother technology that will greatly enhance the realism of virtual reality is nanobots: miniature robots the size of blood cells that travel through the capillaries of our brains and communicate with biological neurons.");
                Console.WriteLine("\t\t2. Nanoid robotics, or for short, nanorobotics or nanobotics, is an emerging technology field creating machines or robots whose components are at or near the scale of a nanometer. ");
                Console.WriteLine("\t\tThey can be used very effectively for drug delivery. ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. NANO- + BOT entry 1.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }



            void nanotechnology()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tNanotechnology:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/ˌnænəˌtekˈnɒləʤiː, ˌnænoʊ-/ /ˌnænə(ʊ)tekˈnɒləʤi/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  helping to considerably improve, even revolutionize, many technology and industry sectors: information technology, homeland security, medicine, transportation, energy, food safety, and environmental science, among many others.");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\tthe branch of engineering that deals with things smaller than 100 nanometers (especially with the manipulation of individual molecules).");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection:  ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. the manipulation of materials on an atomic or molecular scale especially to build microscopic devices (such as robots).");
                Console.WriteLine("\t\tPlacing atoms as though they were bricks, nanotechnology will give us complete control over the structure of matter, allowing us to build any substance or structure permitted by the laws of nature.");
                Console.WriteLine("\t\t2. Nanotechnology, or nanotech for short, deals with matter at a level that most of us find hard to imagine, since it involves objects with dimensions of 100 billionths of a meter (1/800th of the thickness of a human hair) or less.");
                Console.WriteLine("\t\tNanotechnology is already being used in automobile tires, land-mine detectors, and computer disk drives.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;

            }



            void net()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tNet:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\tˈnet");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tProper Noun:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  e-commerce, e-learning, knowledge sharing, social connectivity, variety of media, file transfer, communication, etc.");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t Short for network, a net is a collection of computers connected to each other. Today, the term net is used to describe the Internet.");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  a worldwide system of computer networks -- a network of networks in which users at any one computer can, if they have permission, get information from any other computer (and sometimes talk directly to users at other computers).");
                Console.WriteLine("\t\tThe Internet.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }



            void network()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tNetwork:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t/ˈnetˌwərk/ /ˈnetwɜːk/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. communication, accessing resources, centralisation of data, transfer of files, increased productivity, etc.");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\tA network consists of two or more computers that are linked in order to share resources (such as printers and CDs), exchange files, or allow electronic communications. The computers on a network may be linked through cables, telephone lines, radio waves, satellites, or infrared light beams.");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. an interconnected system of things or people");
                Console.WriteLine("\t\tallows sharing of network and computing resources.");
                Console.WriteLine("\t\t2. Every network involves hardware and software that connects computers and tools.");
                Console.WriteLine("\t\tYou can establish a network connection using either cable or wireless media.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. 1887, to cover with a network,  from network (n.). From 1940 as to broadcast over a(radio) network;  1972 in reference to computers; by 1982 in reference to persons, to interact with others to exchange information and develop contacts.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }



            void nationalism()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tNationalism:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\tna·​tion·​al·​ism | ˈnash-nə-ˌli-zəm  , ˈna-shə-nə-ˌli-zəm ");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. Nationalism, therefore, seeks to preserve and foster a nation's traditional culture.");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\tlove of country and willingness to sacrifice for it");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. the doctrine that your national culture and interests are superior to any other.");
                Console.WriteLine("\t\tthe doctrine that nations should act independently (rather than collectively) to attain their goals.");
                Console.WriteLine("\t\t2. the aspiration for national independence felt by people under foreign domination.");
                Console.WriteLine("\t\tloyalty and devotion to a nation.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. national +‎ -ism");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }




            void needle()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tNeedle:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\tnee·​dle | ˈnē-dᵊl  ");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. , basic implement used in sewing or embroidering and, in variant forms, for knitting and crocheting.");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\tsmall, slender, rodlike, with a sharply pointed end to facilitate passing through fabric and with the opposite end slotted to carry a thread.");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. a sharp pointed implement (usually steel).");
                Console.WriteLine("\t\t any of various devices for carrying thread and making stitches (as in crocheting or knitting).");
                Console.WriteLine("\t\t2. a slender hollow instrument for introducing material into or removing material from the body (as by insertion under the skin).");
                Console.WriteLine("\t\tan extremely thin solid usually stainless steel instrument used in acupuncture and inserted through the skin.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.From Middle English nedle, from Old English nædl, from Proto-Germanic *nēþlō, from pre-Germanic *neh₁-tleh₂, from Proto-Indo-European *(s)néh₁- ‘to spin, twist’ (compare Dutch naaien, Welsh nyddu, Latin nēre, Lithuanian snāju, Sanskrit snāyati ‘wraps up, winds’). Related to snood.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }


            void nothing()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tNothing:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\tnoth·​ing |  ˈnə-thiŋ  ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tNoun:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. to indicate that something or someone is not important or significant.");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t\a quantity of no importance.");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: ");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. not any thing : no thing.");
                Console.WriteLine("\t\tno part");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. no +‎ thing.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }



            void offer()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tOffer:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\tob·​jec·​tive |  əb-ˈjek-tiv  , äb- ");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tAdjective:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. something that one's efforts or actions are intended to attain or accomplish.");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\texpressing or dealing with facts or conditions as perceived without distortion by personal feelings, prejudices, or interpretations.");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: of a test : limited to choices of fixed alternatives and reducing subjective factors to a minimum.");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. of, relating to, or being an object, phenomenon, or condition in the realm of sensible experience independent of individual thought and perceptible by all observers : having reality independent of the mind.");
                Console.WriteLine("\t\tinvolving or deriving from sense perception or experience with actual objects, conditions, or phenomena.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. borrowed from Medieval Latin objectīvus considered in relation to its purpose, relating to an object of thought,  from objectum something presented to the mind, goal, aim + Latin -īvus -IVE — more at OBJECT entry 1.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }


            void obedient()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tObedient:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\toʊˈbiːdiːənt/ /əˈbiːdɪənt/");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tAdjective:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. As an officer he was obedient and never disputed my orders or argued with them.");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\tdutifully complying with the commands or instructions of those in authority.");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection:");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. submissive to the restraint or command of authority : willing to obey.");
                Console.WriteLine("\t\tcomplying or willing to comply with orders or requests; submissive to another's will.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. From Latin oboediēns, present active participle of oboediō (“obey”)..");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }



            void offensive()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tOffensive:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\tof·​fen·​sive |  ə-ˈfen(t)-siv  , especially for sense 1 ˈä-ˌfen(t)-, ˈȯ-  ");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tAdjective:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. The defensive team nearly equipoised the offensive team.");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t\the action of attacking an enemy.");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: for the purpose of attack rather than defense.");//more explanation pero kung walang nakalagay dito ok lang
                
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. From French offensif, from Latin as if *offensivus, from offendere (“to offend”), past participle offensus; see offend.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }


            void online()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tOnline:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\ton·​line |  ˈȯn-ˈlīn  , ˈän-ˈlīn ");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tAdjective:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.  to complete many everyday tasks and errands. For example, you can manage your bank account, pay your bills, etc.");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t\being in progress now.");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: connected to, served by, or available through a system and especially a computer or telecommunications system (such as the Internet).");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. connected to a computer network or accessible by computer.");
                Console.WriteLine("\t\ton a regular route of a railroad or bus or airline system.");
                

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. on +‎ line");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }


            void objective()
            {
                Program p = new();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t\tObjective:");// uppercase lagi yung unahan ng salita same lang nung nakalagay sa taas.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\tob·​jec·​tive |  əb-ˈjek-tiv  , äb- ");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tAdjective:");// lalagay nyo naman dito if Noun, Pronoun, Verb yung salita or kung anomang klase sya
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.   something that one's efforts or actions are intended to attain or accomplish.");//example or pano pasya pwede gamitin
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\texpressing or dealing with facts or conditions as perceived without distortion by personal feelings, prejudices, or interpretations.");//explanation
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tInterjection: of a test : limited to choices of fixed alternatives and reducing subjective factors to a minimum.");//more explanation pero kung walang nakalagay dito ok lang
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1.of, relating to, or being an object, phenomenon, or condition in the realm of sensible experience independent of individual thought and perceptible by all observers : having reality independent of the mind.");
                Console.WriteLine("\t\tinvolving or deriving from sense perception or experience with actual objects, conditions, or phenomena");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\tEtymology");//kung san nag mula or kelan start ginamit, minsan walang ganito so pag wala no need lagyan nyo nalang sa unahan ng // sa Console.Writeline para ma comment out nalang.
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t1. borrowed from Medieval Latin objectīvus 'considered in relation to its purpose, relating to an object of thought, \" from objectum something presented to the mind, goal, aim  + Latin -īvus -IVE — more at OBJECT entry 1");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t ");
                p.iwasBackbottonhehe = Console.ReadLine();
                if (p.iwasBackbottonhehe == "e")
                {
                    EnglishDic();
                }
                if (p.iwasBackbottonhehe == "E")
                {
                    EnglishDic();
                }
                else
                {
                    ;
                }
                EnglishDic(); return;
            }












































        }

    }


}













//void sciAnaNoContent()
//{

//    Program p = new();
//    Console.BackgroundColor = ConsoleColor.Black;
//    Console.Clear();
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.Write(@"
//                                           /
//                        _,.------....___,.' ',.-.
//                     ,-'          _,.--' |
//                   , '         _.-'.
//                  /   ,     , '                   `
//                 .   /     /                     ``.
//                 |  |     .                       \.\
//       ____ | ___._.  | __               \ `.
//     .'    `---''       ``'-.--''`  \               .  \
//    .  , __               `              |   .
//    `, '         ,-'.               \             | L
//   , '          '    _.'                -._          /    |
//  ,`-.    , '.   `--'                      >.      ,'     |   SORRY NO AVAILABLE CONTENT
// . .'\'   `-'       __,  , -.         /  `.__.-      , '
// ||:, .           , '  ;  /  / \ `        `.    .      .' /
// j |:D  \          `--'  ', '_  . .         `.__, \   , /
/// L:_ |                 .  '' :_;                `.'.'
//.    '''                  ''''''                    V
// `.                                 .    `.   _, ..  `
//   `, _.    ._, -'/    .. `,'   __  `
//    ) \`._ ___....----''  ,'   .'  \ |   '  \  .
///   `. '`-.--''         _,' ,'     `---' |    `./  |

//._  `'''--.._____..--'   ,             ' |

//| .' `. `-.                /-.           /          ,
//| `._.'    `,_            ;  /         ,'.

//.'          /| `-.        . ,'         ,           ,
// '-.__ __ _,','    '`-..___; -...__   ,.'\ ____.___.'
// `''^--'..'   '-`-^-''--    `-^-'`.'''''''`.,^.`.--'");

//    p.iwasBackbottonhehe = Console.ReadLine();
//    if (p.iwasBackbottonhehe == "e")
//    {
//        sciAnatomy();
//    }
//    if (p.iwasBackbottonhehe == "E")
//    {
//        sciAnatomy();
//    }
//    else
//    {
//        ;
//    }
//    sciAnatomy();
//}


































//references
//play snake
//private static void Snake()
//{
//private static void SnakeGames()//string[] args
//{
//    Snake snake = new Snake();

//    while (true)
//    {

//        snake.Board();

//        snake.Input();

//        snake.Logic();

//    }
//}


////Console.ReadKey();

////Console.ReadLine();
//internal class Snake
//{


//    int Height = 25;
//    int Width = 50;

//    int[] x = new int[50];
//    int[] y = new int[50];

//    int pointsX;
//    int pointsY;

//    int parts = 1;


//    ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
//    char key = 'W';


//    Random random = new Random();

//    Snake()
//    {
//        x[0] = 5;
//        y[0] = 5;
//        Console.CursorVisible = false;
//        pointsX = random.Next(2, (Width - 2));
//        pointsY = random.Next(2, (Height - 2));

//    }


//    public void Board()
//    {
//        Console.BackgroundColor = ConsoleColor.White;
//        Console.ForegroundColor = ConsoleColor.Black;
//        Console.Clear();
//        for (int i = 1; i <= (Width + 2); i++)
//        {
//            Console.SetCursorPosition(i, 1);
//            Console.Write("=");
//        }
//        for (int i = 1; i <= (Width + 2); i++)
//        {
//            Console.SetCursorPosition(i, (Height + 2));
//            Console.Write("=");
//        }
//        for (int i = 1; i <= (Height + 2); i++)
//        {
//            Console.SetCursorPosition(1, i);
//            Console.Write("|");
//        }
//        for (int i = 1; i <= (Height + 2); i++)
//        {
//            Console.SetCursorPosition((Width + 2), i);
//            Console.Write("|");
//        }

//    }

//    public void Input()
//    {
//        if (Console.KeyAvailable)
//        //
//        {
//            keyInfo = Console.ReadKey(true);
//            //
//            key = keyInfo.KeyChar;
//            //
//        }

//    }

//    public void WritePoint(int x, int y)
//    {
//        Console.SetCursorPosition(x, y);
//        Console.Write("S");
//    }

//    public void Logic()
//    {
//        if (x[0] == pointsX)
//        {
//            if (y[0] == pointsY)
//            {
//                parts++;
//                pointsX = random.Next(2, (Width - 2));
//                pointsY = random.Next(2, (Height - 2));

//            }
//        }
//        for (int i = parts; i > 1; i--)
//        {
//            x[i - 1] = x[i - 2];
//            y[i - 1] = y[i - 2];
//        }
//        switch (key)
//        {
//            case 'w':
//                y[0]--;
//                break;
//            case 's':
//                y[0]++;
//                break;
//            case 'd':
//                x[0]++;
//                break;
//            case 'a':
//                x[0]--;
//                break;

//        }
//        for (int i = 0; i <= (parts - 1); i++)
//        {
//            WritePoint(x[i], y[i]);
//            WritePoint(pointsX, pointsY);

//        }
//        Thread.Sleep(100);

//    }





//}

//Console.WriteLine("\n\n\n");
//Console.WriteLine("\t\t    CCCCCCCCCCCCCCCCCC          OOOOOOOOOOOOOOOO      NNNNNNNN           NNNN  ");
//Console.WriteLine("\t\t  CCCCCCCCCCCCCCCCCCCCCC      OOOOOOOOOOOOOOOOOOOO    NNNNNNNNN          NNNN  ");
//Console.WriteLine("\t\t CCC                  CCC    OOO                OOO   NNNNNNNNNN         NNNN  ");
//Console.WriteLine("\t\tCCC                    CCC  OOO                  OOO  NNNN  NNNNN        NNNN  ");
//Console.WriteLine("\t\tCCC                         OOO                  OOO  NNNN   NNNNN       NNNN  ");
//Console.WriteLine("\t\tCCC                         OOO                  OOO  NNNN    NNNNN      NNNN  ");
//Console.WriteLine("\t\tCCC                         OOO                  OOO  NNNN     NNNNN     NNNN  ");
//Console.WriteLine("\t\tCCC                         OOO                  OOO  NNNN      NNNNN    NNNN  ");
//Console.WriteLine("\t\tCCC                         OOO                  OOO  NNNN       NNNNN   NNNN  ");
//Console.WriteLine("\t\tCCC                    CCC  OOO                  OOO  NNNN        NNNNNN NNNN  ");
//Console.WriteLine("\t\t CCC                  CCC    OOO                OOO   NNNN         NNNNNNNNNN  ");
//Console.WriteLine("\t\t  CCCCCCCCCCCCCCCCCCCCCC      OOOOOOOOOOOOOOOOOOOO    NNNN          NNNNNNNNN  ");
//Console.WriteLine("\t\t    CCCCCCCCCCCCCCCCCC          OOOOOOOOOOOOOOOO      NNNN           NNNNNNNN  ");
