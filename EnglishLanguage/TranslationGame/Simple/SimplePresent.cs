using EnglishLanguage.Model;

namespace EnglishLanguage.Phrases.Simple
{
    public class SimplePresent
    {
        public List<TranslationGameModel> List()
        {
            var simplePresentList = new List<TranslationGameModel>()
            {
                new TranslationGameModel
                {
                    Value = "What's your name?",
                    Description = "Qual é o seu nome?"
                },
                new TranslationGameModel
                {
                    Value = "Eu não estou dormindo agora.",
                    Description = "I'm not sleeping now."
                },
                new TranslationGameModel
                {
                    Value = "I don't speak French.",
                    Description = "Eu não falo Francês."
                },
                new TranslationGameModel
                {
                    Value = "He plays soccer very well.",
                    Description = "Ele joga futebol muito bem."
                },
                new TranslationGameModel
                {   
                    Value = "I don't like soccer.",
                    Description = "Eu não gosto de futebol."
                },
                new TranslationGameModel
                {
                    Value = "Eu estou errado?",
                    Description = "Am I Wrong?"
                },
                new TranslationGameModel
                {
                    Value = "How often do you watch movies?",
                    Description = "Com que frequencia voce assiste filme?"
                }
            };

            return simplePresentList;
        }
    }
}
