using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RaceController : MonoBehaviour
{
    GameObjectFindController findController;

    private void Start()
    {
        findController = GameObject.Find("Canvas").GetComponent<GameObjectFindController>();
    }

    public void RaceChanger()
    {
        string raceSelected = findController.raceSelected.text;
        findController.race.text = raceSelected;
        SetRaceToCharacter(raceSelected);
    }
    public void AddRaceProficiencie(string proficiencie)
    {
        findController.character.proficienciesRace.Add(proficiencie);
        findController.textDataController.ProficienciesAndLanguagesInfoUpdater();
    }

    private void SetRaceToCharacter(string raceSelected)
    {
        findController.character.race = raceSelected;

        switch (raceSelected)
        {
            case "Race": SetRaceDefault(); break;
            case "Горный Дварф": SetRaceMountainDvarf(); break;
            case "Холмовой Дварф": SetRaceHillDvarf(); break;
            case "Высший Эльф": SetRaceHighElf(); break;
            case "Лесной Эльф": SetRaceForestElf(); break;
            case "Темный Эльф": SetRaceDarkElf(); break;
            case "Коренастый Полурослик": SetRaceStockyHalfling(); break;
            case "Легконогий Полурослик": SetRaceLightfootHalfling(); break;
            case "Человек": SetRaceHuman(); break;
            case "Лесной Гном": SetRaceForestGnome(); break;
            case "Скальный Гном": SetRaceRockGnome(); break;
            case "Полуэльф": SetRaceHalfElf(); break;
            case "Полуорк": SetRaceHalfOrc(); break;

            default:
                break;
        }
        findController.abilityController.AbilityUpdateInfoAll();
        findController.textDataController.FeaturesInfoUpdater();
        findController.textDataController.ProficienciesAndLanguagesInfoUpdater();
        findController.textDataController.SpeedInfoUpdate();
    }

    private void SetRaceDefault()
    {
        findController.character.strengthRace = 0;
        findController.character.dexterityRace = 0;
        findController.character.constitutionRace = 0;
        findController.character.intelligenceRace = 0;
        findController.character.wisdomRace = 0;
        findController.character.charismaRace = 0;

        findController.character.speed = 0;

        findController.skills["PerceptionWisToggle"].GetComponent<Toggle>().isOn = false;
        findController.skills["StrengthIntimidationChaToggle"].GetComponent<Toggle>().isOn = false;

        findController.character.languagesRace = new List<string>();
        findController.character.proficienciesRace = new List<string>();
        findController.character.featuresRace = new List<string>();
    }
    private void SetRaceMountainDvarf()
    {
        findController.character.strengthRace = 2;
        findController.character.dexterityRace = 0;
        findController.character.constitutionRace = 2;
        findController.character.intelligenceRace = 0;
        findController.character.wisdomRace = 0;
        findController.character.charismaRace = 0;

        findController.character.speed = 25;

        findController.skills["PerceptionWisToggle"].GetComponent<Toggle>().isOn = false;
        findController.skills["StrengthIntimidationChaToggle"].GetComponent<Toggle>().isOn = false;

        findController.character.languagesRace = new List<string>
        {
            "Общий",
            "Дварфский"
        };
        findController.character.proficienciesRace = new List<string>
        {
            "Легкий доспех",
            "Средний доспех",
            "Боевой топор",
            "Ручной топор",
            "Легкий молот",
            "Боевой молот",
            "Ручной топор"
        };
        findController.character.featuresRace = new List<string>
        {
            "Темное зрение 60",

            "Дварфская устойчивость. \n Вы совершаете с " +
            "преимуществом спасброски от яда и вы получаете " +
            "сопротивление к урону ядом",
            
            "Знание камня. \n Если вы совершаете проверку " +
            "Интеллекта (История), связанную с происхождением" +
            " работы по камню, вы считаетесь владеющим " +
            "навыком История, и добавляете к проверке удвоенный" +
            " бонус мастерства вместо обычного.",
        };
    }
    private void SetRaceHillDvarf()
    {
        findController.character.strengthRace = 0;
        findController.character.dexterityRace = 0;
        findController.character.constitutionRace = 2;
        findController.character.intelligenceRace = 0;
        findController.character.wisdomRace = 1;
        findController.character.charismaRace = 0;

        findController.character.speed = 25;

        findController.skills["PerceptionWisToggle"].GetComponent<Toggle>().isOn = false;
        findController.skills["StrengthIntimidationChaToggle"].GetComponent<Toggle>().isOn = false;

        findController.character.languagesRace = new List<string>
        {
            "Общий",
            "Дварфский"
        };
        findController.character.proficienciesRace = new List<string>
        {
            "Легкий доспех",
            "Средний доспех",
            "Боевой топор",
            "Ручной топор",
            "Легкий молот",
            "Боевой молот",
            "Ручной топор"
        };
        findController.character.featuresRace = new List<string>
        {
            "Темное зрение 60",

            "Дварфская устойчивость. \nВы совершаете с " +
            "преимуществом спасброски от яда и вы получаете " +
            "сопротивление к урону ядом",

            "Знание камня. \nЕсли вы совершаете проверку " +
            "Интеллекта (История), связанную с происхождением" +
            " работы по камню, вы считаетесь владеющим " +
            "навыком История, и добавляете к проверке удвоенный" +
            " бонус мастерства вместо обычного.",

            "Дварфская выдержка. \nМаксимальное значение " +
            "ваших хитов увеличивается на 1, и вы получаете 1" +
            "дополнительный хит с каждым новым уровнем"
        };
    }
    private void SetRaceHighElf()
    {
        findController.character.strengthRace = 0;
        findController.character.dexterityRace = 2;
        findController.character.constitutionRace = 0;
        findController.character.intelligenceRace = 1;
        findController.character.wisdomRace = 0;
        findController.character.charismaRace = 0;

        findController.character.speed = 30;

        findController.skills["PerceptionWisToggle"].GetComponent<Toggle>().isOn = true;
        findController.skills["StrengthIntimidationChaToggle"].GetComponent<Toggle>().isOn = false;

        findController.character.languagesRace = new List<string>
        {
            "Общий",
            "Эльфийский"
        };
        findController.character.proficienciesRace = new List<string>
        {
            "Длинный меч",
            "Короткий меч",
            "Длинный лук",
            "Короткий лук"
        };
        findController.character.featuresRace = new List<string>
        {
            "Темное зрение 60",

            "Наследие фей. \nВы совершаете с преимуществом" +
            " спасброски от очарования, и вас невозможно" +
            " магически усыпить.",

            "Транс. \nЭльфы не спят. Вместо этого они погружаются" +
            " в глубокую медитацию, находясь в полубессознательном" +
            " состоянии до 4 часов в сутки (обычно такую медитацию" +
            " называют трансом). Во время этой медитации вы можете" +
            " грезить о разных вещах. Некоторые из этих грёз являются" +
            " ментальными упражнениями, выработанными за годы" +
            " тренировок. После такого отдыха вы получаете все" +
            " преимущества, которые получает человек после 8 часов сна.",

            "Заговор. \nВы знаете один заговор из списка заклинаний" +
            " волшебника. Базовой характеристикой для его" +
            " использования является Интеллект.",

            "Дополнительный язык. \nВы можете говорить, читать" +
            " и писать на ещё одном языке, на ваш выбор."
        };
    }
    private void SetRaceForestElf()
    {
        findController.character.strengthRace = 0;
        findController.character.dexterityRace = 2;
        findController.character.constitutionRace = 0;
        findController.character.intelligenceRace = 0;
        findController.character.wisdomRace = 1;
        findController.character.charismaRace = 0;

        findController.character.speed = 35;

        findController.skills["PerceptionWisToggle"].GetComponent<Toggle>().isOn = true;
        findController.skills["StrengthIntimidationChaToggle"].GetComponent<Toggle>().isOn = false;

        findController.character.languagesRace = new List<string>
        {
            "Общий",
            "Эльфийский"
        };
        findController.character.proficienciesRace = new List<string>
        {
            "Длинный меч",
            "Короткий меч",
            "Длинный лук",
            "Короткий лук"
        };
        findController.character.featuresRace = new List<string>
        {
            "Темное зрение 60",

            "Наследие фей. \nВы совершаете с преимуществом" +
            " спасброски от очарования, и вас невозможно" +
            " магически усыпить.",

            "Транс. \nЭльфы не спят. Вместо этого они погружаются" +
            " в глубокую медитацию, находясь в полубессознательном" +
            " состоянии до 4 часов в сутки (обычно такую медитацию" +
            " называют трансом). Во время этой медитации вы можете" +
            " грезить о разных вещах. Некоторые из этих грёз являются" +
            " ментальными упражнениями, выработанными за годы" +
            " тренировок. После такого отдыха вы получаете все" +
            " преимущества, которые получает человек после 8 часов сна.",

            "Маскировка в дикой местности. \nВы можете предпринять" +
            " попытку спрятаться, даже если вы слабо заслонены" +
            " листвой, сильным дождём, снегопадом, туманом или" +
            " другими природными явлениями."
        };
    }
    private void SetRaceDarkElf()
    {
        findController.character.strengthRace = 0;
        findController.character.dexterityRace = 2;
        findController.character.constitutionRace = 0;
        findController.character.intelligenceRace = 0;
        findController.character.wisdomRace = 0;
        findController.character.charismaRace = 1;

        findController.character.speed = 30;

        findController.skills["PerceptionWisToggle"].GetComponent<Toggle>().isOn = true;
        findController.skills["StrengthIntimidationChaToggle"].GetComponent<Toggle>().isOn = false;

        findController.character.languagesRace = new List<string>
        {
            "Общий",
            "Эльфийский"
        };
        findController.character.proficienciesRace = new List<string>
        {
            "Рапира",
            "Короткий меч",
            "Ручной арбалет"
        };
        findController.character.featuresRace = new List<string>
        {
            "Темное зрение 120",

            "Наследие фей. \nВы совершаете с преимуществом" +
            " спасброски от очарования, и вас невозможно" +
            " магически усыпить.",

            "Транс. \nЭльфы не спят. Вместо этого они погружаются" +
            " в глубокую медитацию, находясь в полубессознательном" +
            " состоянии до 4 часов в сутки (обычно такую медитацию" +
            " называют трансом). Во время этой медитации вы можете" +
            " грезить о разных вещах. Некоторые из этих грёз являются" +
            " ментальными упражнениями, выработанными за годы" +
            " тренировок. После такого отдыха вы получаете все" +
            " преимущества, которые получает человек после 8 часов сна.",

            "Чувствительность к солнцу. \nВы совершаете с помехой броски" +
            " атаки и проверки Мудрости (Внимательность), основанные" +
            " на зрении, если вы, цель вашей атаки или изучаемый предмет" +
            " расположены на прямом солнечном свете.",

            "Магия дроу. \nВы знаете заклинание пляшущие огоньки. " +
            "Когда вы достигаете 3 уровня, вы можете один раз в день " +
            "использовать заклинание огонь фей. При достижении 5 уровня " +
            "вы также сможете раз в день использовать заклинание тьма. " +
            "«Раз в день» означает, что вы должны окончить продолжительный " +
            "отдых, прежде чем сможете наложить это заклинание ещё " +
            "раз посредством данного умения. Базовой характеристикой для их " +
            "использования является Харизма."
        };
    }
    private void SetRaceStockyHalfling()
    {
        findController.character.strengthRace = 0;
        findController.character.dexterityRace = 2;
        findController.character.constitutionRace = 1;
        findController.character.intelligenceRace = 0;
        findController.character.wisdomRace = 0;
        findController.character.charismaRace = 0;

        findController.character.speed = 25;

        findController.skills["PerceptionWisToggle"].GetComponent<Toggle>().isOn = false;
        findController.skills["StrengthIntimidationChaToggle"].GetComponent<Toggle>().isOn = false;

        findController.character.languagesRace = new List<string>
        {
            "Общий",
            "Полуросликов"
        };
        findController.character.proficienciesRace = new();
        findController.character.featuresRace = new List<string>
        {
            "Везучий. \nЕсли при броске атаки, проверке характеристики" +
            " или спасброске у вас выпало «1», вы можете перебросить" +
            " кость, и должны использовать новый результат.",

            "Храбрый. \nВы совершаете с преимуществом спасброски от испуга",

            "Проворство полуросликов. \nВы можете проходить сквозь пространство," +
            " занятое существами, чей размер больше вашего.",

            "Устойчивость коренастых. \nВы совершаете с преимуществом " +
            "спасброски от яда, и вы получаете сопротивление к урону ядом."
        };
    }
    private void SetRaceLightfootHalfling()
    {
        findController.character.strengthRace = 0;
        findController.character.dexterityRace = 2;
        findController.character.constitutionRace = 0;
        findController.character.intelligenceRace = 0;
        findController.character.wisdomRace = 0;
        findController.character.charismaRace = 1;

        findController.character.speed = 25;

        findController.skills["PerceptionWisToggle"].GetComponent<Toggle>().isOn = false;
        findController.skills["StrengthIntimidationChaToggle"].GetComponent<Toggle>().isOn = false;

        findController.character.languagesRace = new List<string>
        {
            "Общий",
            "Полуросликов"
        };
        findController.character.proficienciesRace = new();
        findController.character.featuresRace = new List<string>
        {
            "Везучий. \nЕсли при броске атаки, проверке характеристики" +
            " или спасброске у вас выпало «1», вы можете перебросить" +
            " кость, и должны использовать новый результат.",

            "Храбрый. \nВы совершаете с преимуществом спасброски от испуга",

            "Проворство полуросликов. \nВы можете проходить сквозь пространство," +
            " занятое существами, чей размер больше вашего.",

            "Естественная скрытность. \nВы можете предпринять попытку " +
            "скрыться даже если заслонены только существом, " +
            "превосходящими вас в размере как минимум на одну категорию"
        };
    }
    private void SetRaceHuman()
    {
        findController.character.strengthRace = 1;
        findController.character.dexterityRace = 1;
        findController.character.constitutionRace = 1;
        findController.character.intelligenceRace = 1;
        findController.character.wisdomRace = 1;
        findController.character.charismaRace = 1;

        findController.character.speed = 30;

        findController.skills["PerceptionWisToggle"].GetComponent<Toggle>().isOn = false;
        findController.skills["StrengthIntimidationChaToggle"].GetComponent<Toggle>().isOn = false;

        findController.character.languagesRace = new List<string>
        {
            "Общий"
        };
        findController.character.proficienciesRace = new();
        findController.character.featuresRace = new List<string>
        {
            "Дополнительный язык. \nВы можете говорить, читать" +
            " и писать на ещё одном языке, на ваш выбор.",
        };
    }
    private void SetRaceForestGnome()
    {
        findController.character.strengthRace = 0;
        findController.character.dexterityRace = 1;
        findController.character.constitutionRace = 0;
        findController.character.intelligenceRace = 2;
        findController.character.wisdomRace = 0;
        findController.character.charismaRace = 0;

        findController.character.speed = 25;

        findController.skills["PerceptionWisToggle"].GetComponent<Toggle>().isOn = false;
        findController.skills["StrengthIntimidationChaToggle"].GetComponent<Toggle>().isOn = false;

        findController.character.languagesRace = new List<string>
        {
            "Общий",
            "Гномий"
        };
        findController.character.proficienciesRace = new();
        findController.character.featuresRace = new List<string>
        {
            "Темное зрение 60",

            "Гномья хитрость. \nВы совершаете с преимуществом" +
            " спасброски Интеллекта, Мудрости и Харизмы против магии.",

            "Природная иллюзия. \nВы знаете заклинание малая иллюзия. " +
            "Базовой характеристикой для его использования является Интеллект.",

            "Общение с маленькими зверями. \nС помощью звуков и жестов вы " +
            "можете передавать простые понятия Маленьким или ещё " +
            "меньшим зверям. Лесные гномы любят животных и часто держат " +
            "белок, барсуков, кроликов, кротов, дятлов и других животных в " +
            "качестве питомцев."
        };
    }
    private void SetRaceRockGnome()
    {
        findController.character.strengthRace = 0;
        findController.character.dexterityRace = 0;
        findController.character.constitutionRace = 1;
        findController.character.intelligenceRace = 2;
        findController.character.wisdomRace = 0;
        findController.character.charismaRace = 0;

        findController.character.speed = 25;

        findController.skills["PerceptionWisToggle"].GetComponent<Toggle>().isOn = false;
        findController.skills["StrengthIntimidationChaToggle"].GetComponent<Toggle>().isOn = false;

        findController.character.languagesRace = new List<string>
        {
            "Общий",
            "Гномий"
        };
        findController.character.proficienciesRace = new();
        findController.character.featuresRace = new List<string>
        {
            "Темное зрение 60",

            "Гномья хитрость. \nВы совершаете с преимуществом" +
            " спасброски Интеллекта, Мудрости и Харизмы против магии.",

            "Ремесленные знания. При совершении проверки Интеллекта " +
            "(История) применительно к магическому, алхимическому " +
            "или технологическому объекту, вы можете добавить к " +
            "проверке удвоенный бонус мастерства вместо обычного.",

            "Жестянщик. Вы владеете ремесленными инструментами " +
            "(инструменты жестянщика). С их помощью вы можете, потратив " +
            "1 час времени и материалы на сумму в 10 зм, создать Крошечное " +
            "механическое устройство (КД 5, 1 хит). Это устройство " +
            "перестаёт работать через 24 часа (если вы не потратите 1 час " +
            "на поддержание его работы). Вы можете действием разобрать его; " +
            "в этом случае вы можете получить обратно использованные материалы." +
            " Одновременно вы можете иметь не более трёх таких устройств. " +
            "При создании устройства выберите один из следующих вариантов: " +
            "\nЗаводная игрушка. Эта заводная игрушка изображает животное, " +
            "чудовище или существо, вроде лягушки, мыши, птицы, дракона или солдатика." +
            "Поставленная на землю, она проходит 5 футов в случайном направлении " +
            "за каждый ваш ход, издавая звуки, соответствующие изображаемому существу." +
            "\nЗажигалка.Это устройство производит миниатюрный огонёк, с " +
            "помощью которого можно зажечь свечу, факел или костёр. Использование " +
            "этого устройства требует действия. \nМузыкальная шкатулка. При открытии эта " +
            "шкатулка проигрывает мелодию средней громкости. Шкатулка перестаёт играть " +
            "если мелодия закончилась или если шкатулку закрыли."
        };
    }
    private void SetRaceHalfElf()
    {
        findController.character.strengthRace = 0;
        findController.character.dexterityRace = 0;
        findController.character.constitutionRace = 0;
        findController.character.intelligenceRace = 0;
        findController.character.wisdomRace = 0;
        findController.character.charismaRace = 2;

        findController.character.speed = 30;

        findController.skills["PerceptionWisToggle"].GetComponent<Toggle>().isOn = false;
        findController.skills["StrengthIntimidationChaToggle"].GetComponent<Toggle>().isOn = false;

        findController.character.languagesRace = new List<string>
        {
            "Общий",
            "Эльфийский"
        };
        findController.character.proficienciesRace = new();
        findController.character.featuresRace = new List<string>
        {
            "Темное зрение 60",

            "Наследие фей. \nВы совершаете с преимуществом" +
            " спасброски от очарования, и вас невозможно" +
            " магически усыпить.",

            "Универсальность навыков. \nВы получаете владение двумя навыками на ваш выбор.",

            "Увеличение характеристик. Значения двух ваших характеристик " +
            "на ваш выбор увеличиваются на 1 (кроме харизмы)",

            "Дополнительный язык. \nВы можете говорить, читать" +
            " и писать на ещё одном языке, на ваш выбор.",
        };
    }
    private void SetRaceHalfOrc()
    {
        findController.character.strengthRace = 2;
        findController.character.dexterityRace = 0;
        findController.character.constitutionRace = 1;
        findController.character.intelligenceRace = 0;
        findController.character.wisdomRace = 0;
        findController.character.charismaRace = 0;

        findController.character.speed = 30;
        
        findController.skills["PerceptionWisToggle"].GetComponent<Toggle>().isOn = false;
        findController.skills["StrengthIntimidationChaToggle"].GetComponent<Toggle>().isOn = true;

        findController.character.languagesRace = new List<string>
        {
            "Общий",
            "Орочий"
        };
        findController.character.proficienciesRace = new();
        findController.character.featuresRace = new List<string>
        {
            "Темное зрение 60",

            "Наследие фей. \nВы совершаете с преимуществом" +
            " спасброски от очарования, и вас невозможно" +
            " магически усыпить.",

            "Непоколебимая стойкость. \nЕсли ваши хиты опустились " +
            "до нуля, но вы при этом не убиты, ваши хиты вместо " +
            "этого опускаются до 1. Вы не можете использовать эту " +
            "способность снова, пока не завершите длительный отдых.",

            "Свирепые атаки. \nЕсли вы совершили критическое попадание " +
            "рукопашной атакой оружием, вы можете добавить к урону " +
            "ещё одну кость урона оружия.",
        };
    }
}