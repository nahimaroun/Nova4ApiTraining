using CORDesignPattern.Teams;

namespace CORDesignPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            ContextObject question = new ContextObject() { Question = "Who is the fastest human ?" };

            TeamThree teamThree = new TeamThree(null, question);
            TeamTwo teamTwo = new TeamTwo(teamThree, question);
            TeamOne teamOne = new TeamOne(teamTwo, question);

            teamOne.HandleRequest();
        }
    }
}