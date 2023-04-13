using EnglishLanguage.Model;

namespace EnglishLanguage.Phrases.SimplePresent
{
    public class SimplePresent
    {
        public List<ValuesModel> List()
        {
            var simplePresentList = new List<ValuesModel>()
            {
                new ValuesModel
                {
                    Value = "What's your name?",
                    Description = "Qual é o seu nome?"
                },
                new ValuesModel
                {
                    Value = "Eu não estou dormindo agora.",
                    Description = "I'm not sleeping now."
                },
                new ValuesModel
                {
                    Value = "I don't speak French.",
                    Description = "Eu não falo Francês."
                },
                new ValuesModel
                {
                    Value = "He plays soccer very well.",
                    Description = "Ele joga futebol muito bem."
                },
                new ValuesModel
                {
                    Value = "I don't like soccer.",
                    Description = "Eu não gosto de futebol."
                },
                new ValuesModel
                {
                    Value = "Eu estou errado?",
                    Description = "Am my wrong?"
                },
                new ValuesModel
                {
                    Value = "How often do you watch movies?",
                    Description = "Com que frequencia voce assiste filme?"
                }
            };

            return simplePresentList;
        }
    }
}
