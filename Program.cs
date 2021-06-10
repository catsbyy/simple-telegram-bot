using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace MasterFitClubBot
{
    class Program
    {
        static TelegramBotClient MFBot;

        static void Main(string[] args)
        {
            MFBot = new TelegramBotClient(Key.bot_key);
            
            MFBot.OnMessage += MFBotOnMessageReceived;
            MFBot.OnCallbackQuery += MFBotOnCallbackQueryReceived;
            
            var me = MFBot.GetMeAsync().Result;

            Console.WriteLine(me.FirstName);

            MFBot.StartReceiving();
            Console.ReadLine();
            MFBot.StopReceiving();

        }

        private static void MFBotOnCallbackQueryReceived(object sender, Telegram.Bot.Args.CallbackQueryEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static async void MFBotOnMessageReceived(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            var message = e.Message;
            if (message == null || message.Type != MessageType.Text)
                return;

            string name = $"{message.From.FirstName} {message.From.LastName}";
            Console.WriteLine(name + " отправил сообщение: " + message.Text);
                string description, location;
                switch (message.Text)
                {
                    case "/sportdescription 1": description = "Хороший тренажерный зал - это не только комплекс традиционных спортивных тренажеров и снарядов. " +
                            "Очень важно, чтобы в спортзале царил комфорт, который побуждает возвращаться туда вновь и вновь.";
                            location = "Доступно на Оболони, Троещине, Печерске";
                        await MFBot.SendTextMessageAsync(message.From.Id, description);
                        await MFBot.SendTextMessageAsync(message.From.Id, location);
                        break;
                    case "/sportdescription 2": description = "Ушу («комплексы ушу») — это вид спорта. Участники соревнуются в выполнении комплексов, " +
                            "составленных из движений различных стилей, с добавлением акробатических элементов. Оценки выставляются за сложность движений, " +
                            "чёткость их выполнения, техничность и зрелищность исполнения.";
                        location = "Доступно на Оболони";
                        await MFBot.SendTextMessageAsync(message.From.Id, description);
                        await MFBot.SendTextMessageAsync(message.From.Id, location);
                        break;
                    case "/sportdescription 3": description = "Как и любой вид восточного боевого искусства, таэквон-до развивает человека во всех аспектах: физическом, духовном, " +
                            "умственном. Конечно, закладывать основы гармоничного развития лучше в детском возрасте, когда тело и сознание пластичны и быстрее адаптируются " +
                            "к нагрузкам, испытаниям и философии спорта.";
                            location = "Доступно на Оболони, Печерске";
                        await MFBot.SendTextMessageAsync(message.From.Id, description);
                        await MFBot.SendTextMessageAsync(message.From.Id, location);
                        break;
                    case "/sportdescription 4": description = "После курса солярия вы почувствуете, что уже не подвержены случайным простудам, а в период вспышек гриппа сохраняете" +
                            " работоспособность. Кроме того, исчезают зябкость и вялость, ощущение свинцовой тяжести в мышцах по утрам или после непродолжительной работы.";
                            location = "Доступно на Оболони";
                        await MFBot.SendTextMessageAsync(message.From.Id, description);
                        await MFBot.SendTextMessageAsync(message.From.Id, location);
                        break;
                    case "/sportdescription 5": description = "Благодаря экологичности округлых и плавных движений, тайцзицюань доступен для освоения практически всем людям, " +
                            "независимо от пола, возраста и состояния здоровья. Состояние активной медитации при исполнении техник тайцзицюань помогает достичь" +
                            " гармонии с собой и окружающим миром.";
                            location = "Доступно на Оболони";
                        await MFBot.SendTextMessageAsync(message.From.Id, description);
                        await MFBot.SendTextMessageAsync(message.From.Id, location);
                        break;
                    case "/sportdescription 6": description = "Специально разработанные физические упражнения, положительно влияющие на все системы детского организма. " +
                            "Особое внимание направлено на профилактику плоскостопия, формирование правильной осанки и грациозности движений.";
                            location = "Доступно на Оболони, Троещине, Печерске";
                        await MFBot.SendTextMessageAsync(message.From.Id, description);
                        await MFBot.SendTextMessageAsync(message.From.Id, location);
                        break;
                    case "/sportdescription 7": description = "Массаж - это прекрасное средство для того, чтобы быть в бодром тонусе, почувствовать себя шестнадцатилетним, " +
                            "избавится от проблем в позвоночнике и лишнего веса, откорректировать фигуру и просто улучшить самочувствие.";
                            location = "Доступно на Оболони и Троещине";
                        await MFBot.SendTextMessageAsync(message.From.Id, description);
                        await MFBot.SendTextMessageAsync(message.From.Id, location);
                        break;
                    case "/sportdescription 8": description = "Танец – это не просто физическая нагрузка. Танец тонизирует тело, хорошенько 'прочищает мозги' и приводит эмоции в тонус." +
                            " Присоединиться к занятиям можно в любое время, в течение всего сезона. Есть возможность и для индивидуальных занятий в выходные дни или в дневное время будней.";
                            location = "Доступно на Оболони";
                        await MFBot.SendTextMessageAsync(message.From.Id, description);
                        await MFBot.SendTextMessageAsync(message.From.Id, location);
                        break;
                    case "/sportdescription 9": description = "Каратэ - до СИТО - РЮ - это древняя Окинавская школа, характеризуется быстротой передвижения, " +
                            "совмещением мягких блоков с жестким блокированием, использованием встречных ударов, защитой нападением.";
                                location = "Доступно на Оболони, Печерске";
                        await MFBot.SendTextMessageAsync(message.From.Id, description);
                        await MFBot.SendTextMessageAsync(message.From.Id, location);
                        break;
                    case "/sportdescription 10": description = "Восточный танец благотворно влияет на весь организм женщины, осуществляя уникальный массаж внутренних органов живота и малого таза," +
                            " помогает в решении женских проблем, укрепляет мышцы, придает связкам эластичность, а суставам - гибкость," +
                            " развивает координацию, осанку, улучшает кровообращение и делает кожу упругой.";
                            location = "Доступно на Оболони";
                        await MFBot.SendTextMessageAsync(message.From.Id, description);
                        await MFBot.SendTextMessageAsync(message.From.Id, location);
                        break;
                    case "/sportdescription 11": description = "Занятия йогой – это 100% гарантия эффективного избавления от стрессов, переживаний, напряженности. Она помогает обрести" +
                            " психологическое равновесие и умиротворенность. Йога - лучший антидепрессант и стимулятор, поскольку не навязывает никаких требований" +
                            " и не ставит иных условий, кроме желания заняться ею.";
                            location = "Доступно на Оболони, Троещине, Печерске";
                        await MFBot.SendTextMessageAsync(message.From.Id, description);
                        await MFBot.SendTextMessageAsync(message.From.Id, location);
                        break;
                    case "/sportdescription 12": description = "Танцевальные тренировки (боди-балет) с Анной Зелинской – авторская система тренировок," +
                            " объединяющая различные танцевально-спортивные стили и направления. Разминка в стиле танцевальной аэробики переходит" +
                            " в элементы классической и современной хореографии.";
                            location = "Доступно на Оболони, Печерске";
                        await MFBot.SendTextMessageAsync(message.From.Id, description);
                        await MFBot.SendTextMessageAsync(message.From.Id, location);
                        break;
                    case "/sportdescription 13": description = "Аэробикой с успехом занимаются люди всех возрастов, с любой степенью спортивной подготовки. Занятия проводятся в группе," +
                            " под руководством опытного инструктора, поэтому даже новички чувствуют себя комфортно и всегда уверены, что им придут на помощь в непростые моменты.";
                            location = "Доступно на Оболони, Троещине, Печерске";
                        await MFBot.SendTextMessageAsync(message.From.Id, description);
                        await MFBot.SendTextMessageAsync(message.From.Id, location);
                        break;
                    case "/sportdescription 14": description = "Флай Йога – относительно новая система упражнений и методик для улучшения физических качеств и оздоровления организма. " +
                            "Fly-Yoga была основа бывшим профессиональным танцором на Бродвее, гимнастом и акробатом - Кристофером Харрисоном.";
                            location = "Доступно на Оболони";
                        await MFBot.SendTextMessageAsync(message.From.Id, description);
                        await MFBot.SendTextMessageAsync(message.From.Id, location);
                        break;
                    case "/sportdescription 15": description = "Основные принципы Хаду - проработка всех групп мышц (внутренних и внешних), суставов и" +
                            " связок в замедленном темпе с максимальным напряжением, без использования какого-либо" +
                            " вспомогательного оборудования и инвентаря";
                            location = "Доступно на Троещине";
                        await MFBot.SendTextMessageAsync(message.From.Id, description);
                        await MFBot.SendTextMessageAsync(message.From.Id, location);
                        break;
                    case "/sportdescription 16": description = "Шейпинг (от англ. shape - форма) – это физкультурно-оздоровительная система занятий" +
                            " с целью удовлетворения потребности организма в двигательной активности, а также похудения и устранения недостатков телосложения.";
                            location = "Доступно на Оболони";
                        await MFBot.SendTextMessageAsync(message.From.Id, description);
                        await MFBot.SendTextMessageAsync(message.From.Id, location);
                        break;
                    case "/sportdescription 17": description = "Велосипед - это круто. У нас Вы можете взять велосипед на прокат.";
                            location = "Доступно на Оболони";
                        await MFBot.SendTextMessageAsync(message.From.Id, description);
                        await MFBot.SendTextMessageAsync(message.From.Id, location);
                        break;
                    case "/sportdescription": description = "Пожалуйста, введите номер активности (пример, /sportdescription 1)";
                        await MFBot.SendTextMessageAsync(message.From.Id, description);
                        break;
                    default:
                        break;
                }
            
                switch (message.Text)
                {
                    case "/start":
                        string starttext = $"Привет! Рад Вас видеть, {name}! Вот список моих команд: \n" +
                 "/start - так Вы меня активируете\n" +
                 "/links - ссылки на страницы в интернете\n" +
                 "/schedule - расписание занятий\n" +
                 "/contacts - контактные данные фитнес-центров\n" +
                 "/adresses - адреса фитнес-центров\n" +
                 "/discounts - актуальные скидки и акции\n" +
                 "/activities - виды занятий\n" +
                 "/sportdescription (номер) - описание занятия";
                        await MFBot.SendTextMessageAsync(message.From.Id, starttext);
                        break;
                    case "/links":
                        var linksKeyboard = new InlineKeyboardMarkup(
                            new[]
                            {
                            InlineKeyboardButton.WithUrl("Сайт клуба", "https://masterfit.kiev.ua/"),
                            InlineKeyboardButton.WithUrl("Facebook", "https://www.facebook.com/masterfit/"),
                            InlineKeyboardButton.WithUrl("Instagram", "https://www.instagram.com/_master_fit_/")
                            });
                        await MFBot.SendTextMessageAsync(message.From.Id, "Выберите пункт:", replyMarkup: linksKeyboard);
                        break;
                    case "/schedule":
                        string schedule = "Сейчас клуб не работает, так как карантин.";
                        await MFBot.SendTextMessageAsync(message.From.Id, schedule);
                        break;
                    case "/contacts":
                        string contacts = "Фитнес-центр на Оболони: (063) 903 5400\n" +
              "Фитнес-центр на Троещине: (093) 755 3000\n" +
              "Фитнес-центр на Печерске: (093) 110 9090\n";
                        await MFBot.SendTextMessageAsync(message.From.Id, contacts);
                        break;
                    case "/adresses":
                        string adress1 = "Фитнес-центр на Оболони: пр-т Героев Сталинграда, 47 (в здании НВК “Потенциал”), Киев\n";
                        string adress2 = "Фитнес-центр на Троещине: ул.Градинская 6-Б (в здании СШ №308), Киев\n";
                        string adress3 = "Фитнес-центр на Печерске: ул. Лаврская, 2 (в здании СШ №90), Киев\n";
                        await MFBot.SendTextMessageAsync(message.From.Id, adress1);
                        await MFBot.SendLocationAsync(message.From.Id, (float)50.518880, (float)30.512966);
                        await MFBot.SendTextMessageAsync(message.From.Id, adress2);
                        await MFBot.SendLocationAsync(message.From.Id, (float)50.520555, (float)30.601488);
                        await MFBot.SendTextMessageAsync(message.From.Id, adress3);
                        await MFBot.SendLocationAsync(message.From.Id, (float)50.439126, (float)30.550606);
                        break;
                    case "/discounts":
                        string discounts = "Завтра добавлю";
                        await MFBot.SendTextMessageAsync(message.From.Id, discounts);
                        break;
                    case "/activities":
                        string activities = "1. Тренажерный зал\n" +
                        "2. Ушу / Кунг-фу\n" +
                        "3. Таэквон-до\n" +
                        "4. Солярий\n" +
                        "5. Тайцзицюань\n" +
                        "6. Студия 'Аэлита'\n" +
                        "7. Массаж\n" +
                        "8. Латина микс\n" +
                        "9. Каратэ-до\n" +
                        "10. Восточный танец\n" +
                        "11. Йога\n" +
                        "12. Фит-Дэнс\n" +
                        "13. Аэробика\n" +
                        "14. Fly Йога\n" +
                        "15. Хаду + Стретчинг\n" +
                        "16. Шейпинг\n" +
                        "17. Велопрокат";
                        await MFBot.SendTextMessageAsync(message.From.Id, activities);
                        break;
                    default:
                        break;
                }
            
        }
    }
}
