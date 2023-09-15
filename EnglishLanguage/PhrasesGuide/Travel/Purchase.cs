using EnglishLanguage.Model;

namespace EnglishLanguage.PhrasesGuide.Travel
{
    public class Purchase
    {
        public List<PhrasesGuideModel> ListShoppingBasic()
        {
            var PhrasesGuide = new List<PhrasesGuideModel>()
            {
                new PhrasesGuideModel
                {
                    Id = 1,
                    Description = "Pedindo por um item específico",
                    DescriptionBRL = "Você tem ___?",
                    Value = "Do you have ___?"
                },
                new PhrasesGuideModel
                {
                    Id = 2,
                    Description = "Perguntando sobre a localização de um item específico",
                    DescriptionBRL = "Onde eu encontro ___?",
                    Value = "Where can I find ___?"
                },
                new PhrasesGuideModel
                {
                    Id = 3,
                    Description = "Perguntando sobre o preço de um item específico",
                    DescriptionBRL = "Quanto custa isso?",
                    Value = "How much is this?"
                },
                new PhrasesGuideModel
                {
                    Id = 4,
                    Description = "Perguntando sobre os horários em que a loja abre ou fecha",
                    DescriptionBRL = "Que horas você abre/fecha?",
                    Value = "What time do you open/close?"
                },
                new PhrasesGuideModel
                {
                    Id = 5,
                    Description = "Perguntando se a loja aceita cartão de crédito",
                    DescriptionBRL = "Posso pagar com cartão de crédito?",
                    Value = "May I pay with credit card?"
                }
            };

            return PhrasesGuide;
        }

        public List<PhrasesGuideModel> ListShoppingClothes()
        {
            var PhrasesGuide = new List<PhrasesGuideModel>()
            {
                new PhrasesGuideModel
                {
                    Id = 1,
                    Description = "Perguntando se é possível provar uma roupa",
                    DescriptionBRL = "Posso provar esta roupa, por favor?",
                    Value = "May I try this on, please?"
                },
                new PhrasesGuideModel
                {
                    Id = 2,
                    Description = "Perguntando por um tamanho específico de roupa",
                    DescriptionBRL = "Você tem essa peça em ___?",
                    Value = "Do you have this in ___?"
                },
                new PhrasesGuideModel
                {
                    Id = 3,
                    Description = "Tamanho de roupa",
                    DescriptionBRL = "... tamanho menor?",
                    Value = "... small?"
                },
                new PhrasesGuideModel
                {
                    Id = 4,
                    Description = "Tamanho de roupa",
                    DescriptionBRL = "... tamanho médio?",
                    Value = "... medium?"
                },
                new PhrasesGuideModel
                {
                    Id = 5,
                    Description = "Tamanho de roupa",
                    DescriptionBRL = ".. tamanho grande?",
                    Value = "... large?"
                },
                new PhrasesGuideModel
                {
                    Id = 6,
                    Description = "Afirmando que a roupa é muito pequena",
                    DescriptionBRL = "É muito pequeno.",
                    Value = "It's too small."
                },
                new PhrasesGuideModel
                {
                    Id = 7,
                    Description = "Afirmando que a roupa é muito grande",
                    DescriptionBRL = "É muito grande.",
                    Value = "It's too big."
                },
                new PhrasesGuideModel
                {
                    Id = 8,
                    Description = "Pedindo opinião sobre como determinada roupa fica em você",
                    DescriptionBRL = "Fico bem nessa roupa?",
                    Value = "Does this look good on me?"
                }
            };

            return PhrasesGuide;
        }
    }
}
