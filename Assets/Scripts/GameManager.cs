using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class GameManager : MonoBehaviour {


    [SerializeField] List<string> cluesTextOriginal = new List<string> {
     //  Places                       Monsters              Peoples               Things                          Spells                 Ideas      

        "Absolam",                    "Aberration",         "Abadar",             "Amulet of Natural Armor",      "Acid Splash",         "Acrobatics",
        "Akiton",                     "Aeon",               "Abraxus",            "Bag of Holding",               "Animate Dead",        "Alignment Shift",
        "Alkenstar",                  "Agathion",           "Alchemist",          "Bastard Sword",                "Ant Haul",            "Appraise",
        "Andoran",                    "Angel",              "Aldern Foxglove",    "Belt of Giant Strength",       "Atonement",           "Archetype",
        "Arcadia",                    "Animal",             "Ambrus Valsin",      "Belt of Incredible Dexterity", "Baleful Polymorph",   "Armor Class",
        "Azlant",                     "Animated Object",    "Ameiko Kaijitsu",    "Belt of Mighty Constitution",  "Barkskin",            "Base Attack Bonus",
        "Belkzen",                    "Archon",             "Aram Zey",           "Boots of Elvenkind",           "Blink",               "Bleed",
        "Brevoy",                     "Asura",              "Arcanist",           "Bracers of Armor",             "Burning Hands",       "Blinded",
        "Casmaron",                   "Azata",              "Aroden",             "Breastplate",                  "Chain Lightning",     "Bluff",
        "Cheliax",                    "Basilisk",           "Asmodeus",           "Cloak of Resistence",          "Charm Person",        "Chaotic Evil",
        "Crown of the World",         "Construct",          "Barbarian",          "Composite Longbow",            "Clone",               "Chaotic Good",
        "Diobel",                     "Cyclops",            "Bard",               "Dagger",                       "Cure Wounds",         "Chaotic Neutral",
        "Druma",                      "Demon",              "Blakros Family",     "Feather Token",                "Detect Magic",        "Charisma",
        "Eye of Abendego",            "Devil",              "Bloodrager",         "Gauntlets",                    "Dimension Door",      "Climb",
        "Galt",                       "Dragon",             "Brawler",            "Gloves of Arrow Snaring",      "Dispel Magic",        "Confused",
        "Geb",                        "Drake",              "Calistria",          "Hand of the Mage",             "Displacement",        "Constitution",
        "Golarian",                   "Elemental",          "Cavalier",           "Handy Haversack",              "Enlarge Person",      "Craft",
        "Hermea",                     "Fey",                "Cayden Cailean",     "Headband of Alluring Charisma","Entangle",            "Dazed",
        "Inner Sea",                  "Gargoyle",           "Cleric",             "Headband of Inspired Wisdom",  "False Life",          "Dazzled ",
        "Irrisen",                    "Gelatinous Cube",    "Decemvirate",        "Headband of Vast Intelligence","Featherfall",         "Deafened",
        "Isger",                      "Genie",              "Desna",              "Heavy Crossbow",               "Fireball",            "Dexterity",
        "Jalmeray",                   "Ghast",              "Drandle Dreng",      "Hide",                         "Fly",                 "Diplomacy",
        "Katapesh",                   "Ghoul",              "Druid",              "Holy Symbol",                  "Ghost Sound",         "Disable Device",
        "Kyonin",                     "Giant",              "Erastil",            "Ioun Stone",                   "Guidance",            "Disguise",
        "Lands of the Linnorm Kings", "Gnoll",              "Fighter",            "Leather",                      "Hideous Laughter",    "Dying",
        "Lastwall",                   "Golem",              "Gorum",              "Longsword",                    "Hold Person",         "Entangled",
        "Magnimar",                   "Hag",                "Gozreh",             "Magic Weapon",                 "Light",               "Escape Artist",
        "Mana Wastes",                "Humanoid",           "Grandmaster Torch",  "Monk's Robe",                  "Mage Armor",          "Exhausted",
        "Mendev",                     "Hydra",              "Gunslinger",         "Muleback Cords",               "Magic Missile",       "Fascinated",
        "Mwangi Expanse",             "Inevitable",         "Hunter",             "Necklace of Fireballs",        "Mirror Image",        "Fatigued",
        "Nex",                        "Leshy",              "Inquisitor",         "Pearl of Power",               "Plane Shift",         "Flat-Footed",
        "Numeria",                    "Linnorm",            "Investigator",       "Phylactery",                   "Poison",              "Fly",
        "Osirion",                    "Lycanthrope",        "Iomedae",            "Rapier",                       "Polymorph",           "Frightened",
        "Qadira",                     "Magical Beast",      "Irori",              "Robe of the Archmagi",         "Prestidigitation",    "Grappled",
        "Razmiran",                   "Mephit",             "Janira Gavix",       "Rod of Wonder",                "Protection from Evil","Handle Animal",
        "Realm of the Mammoth Lords", "Monstrous Humanoid", "Kalkamedes",         "Scimitar",                     "Read Magic",          "Heal",
        "Riddleport",                 "Mummy",              "Kineticist",         "Shield",                       "Resist Energy",       "Helpless",
        "River Kingdoms",             "Naga",               "Kreighton Shaine",   "Shortsword",                    "Resistance",         "Incorporeal",
        "Sandpoint",                  "Ooze",               "Lamashtu",           "Sickle",                       "Scorching Ray",       "Intelligence",
        "Sodden Lands",               "Orc",                "Magus",              "Sleeves of Many Garments",     "Sleep",               "Intimidate",
        "Taldor",                     "Outsider",           "Marcos Farabellus",  "Slippers of Spider Climbing",  "Spark",               "Invisible",
        "The Grand Lodge",            "Plant",              "Medium",             "Snapleaf",                     "Teleport",            "Knowledge Arcana",
        "The Shackles",               "Protean",            "Mesmerist",          "Swarmbane Clasp",              "Time Stop",           "Knowledge Engineering",
        "The Sodden Lands",           "Psychopomp",         "Moloch",             "Thieves Tools",                "Wish",                "Knowledge Geography",
        "The Worldwound",             "Purple Worm",        "Monk",               "Unfettered Shirt",             "Color Spray",         "Knowledge History",
        "Tian Xia",                   "Rakshasa",           "Nethys",             "Unholy Symbol",                "Shocking Grasp",      "Knowledge Local",
        "Ustalav",                    "Roc",                "Ninja",              "Wayfinder",                                           "Knowledge Nature",
        "Varisia",                    "Runelord",           "Norgorber",          "Winged Boots",                                        "Knowledge Nobility",
                                      "Sahuagin",           "Occultist",          "Dark Tapestry",                                       "Knowledge Planes",
                                      "Sinspawn",           "Oracle",             "Starstone",                                           "Knowledge Religion",
                                      "Skeleton",           "Paladin",            "Earthbreaker",                                        "Knowledge Dungeoneering",
                                      "Sphinx",             "Pharasma",           "Wand of Cure Light Wounds",                           "Lawful Evil",
                                      "Swarm",              "Psychic",                                                                   "Lawful Good",
                                      "Treant",             "Ranger",                                                                    "Lawful Neutral",
                                      "Troll",              "Razmir",                                                                    "Linguistics",
                                      "Undead",             "Rogue",                                                                     "Nauseated",
                                      "Vampire",            "Rovagug",                                                                   "Neutral Evil",
                                      "Vermin",             "Samurai",                                                                   "Neutral Good",
                                      "Wight",              "Sarenrae",                                                                  "Paralyzed",
                                      "Wraith",             "Shaman",                                                                    "Pathfinder Society",
                                      "Wyverns",            "Sheila Heidmarch",                                                          "Perception",
                                      "Zombie",             "Shelyn",                                                                    "Perform",
                                      "Otyugh",             "Shifter",                                                                   "Pinned",
                                                            "Skald",                                                                     "Profession",
                                                            "Slayer",                                                                    "Prone",
                                                            "Sorcerer",                                                                  "Ride",
                                                            "Sorrina Westyr",                                                            "Sense Motive",
                                                            "Spiritualist",                                                              "Shaken",
                                                            "Summoner",                                                                  "Sickened",
                                                            "Swashbuckler",                                                              "Skill Check",
                                                            "The Lost Prince",                                                           "Sleight of Hand",
                                                            "Torag",                                                                     "Spellcraft",
                                                            "Urgathoa",                                                                  "Staggered",
                                                            "Vigilante",                                                                 "Stealth",
                                                            "Warpriest",                                                                 "Strength",
                                                            "Witch",                                                                     "Stunned",
                                                            "Wizard",                                                                    "Survival",
                                                            "Zarta Dralneen",                                                            "Swim",
                                                            "Zon-Kuthon",                                                                "Tough AC",
                                                            "Varian Jeggare",                                                            "True Neutral",
                                                            "Sewer Dragons",                                                             "Unconcious",
                                                            "Licktoads",                                                                 "Use Magic Device",
                                                            "Black Marquis",                                                             "Wisdom"
    };

    [SerializeField] List<string> cluesText = null;
    [SerializeField] GameObject[] clueObjects = null;

    [Header("Game Step")]
    [SerializeField] int gameStep = 0;

    GameObject Button = null;
    [SerializeField] GameObject InfoTextBox = null;
    string infoText = null;

    [SerializeField] GameObject team1Icon;
    [SerializeField] GameObject team2Icon;
    [SerializeField] GameObject AssassinsIcon;

    [SerializeField] Texture pathfinderImage;
    [SerializeField] Texture aspisImage;
    [SerializeField] Texture mantisImage;
    [SerializeField] Texture BlankImage;
    [SerializeField] Texture team1Image;
    [SerializeField] Texture team2Image;

    [SerializeField] int team1TotalCards = 9;
    [SerializeField] int team1Cards = 0;
    string team1Tag = "Pathfinder Society";
    [SerializeField] GameObject Team1Text = null;
    [SerializeField] int team1Score = 0;

    [SerializeField] int team2TotalCards = 8;
    [SerializeField] int team2Cards = 0;
    string team2Tag = "Aspis Consortium";
    [SerializeField] GameObject Team2Text = null;
    [SerializeField] int team2Score = 0;

    [SerializeField] int assassinTeamCards = 0;
    string gameWinner;
    [SerializeField] GameObject GameOverScreen;
    [SerializeField] GameObject MenuScreen;
    [SerializeField] GameObject InitativeButton;
    [SerializeField] GameObject EndTurnButton;
    [SerializeField] Transform PlayerFire;

    private enum TurnOrder { firstTeamSelect, secondTeamSelect, assassinSelect, firstTeamTurn, secondTeamTurn };
    

    // Start is called before the first frame update
    void Start()
    {
        SetTeams();
        gameStep = (int)TurnOrder.firstTeamSelect;
        cluesText = new List<string>(cluesTextOriginal); //create copy of all the clue cards so that originals are not altered
    }

    private void Update() {
        team1Score = team1TotalCards - team1Cards;
        team2Score = team2TotalCards - team2Cards;
        Team1Text.GetComponent<TextMeshProUGUI>().text = team1Score.ToString();
        Team2Text.GetComponent<TextMeshProUGUI>().text = team2Score.ToString();
        InfoTextBox.GetComponent<TextMeshProUGUI>().text = infoText;
        InfoText();
        FireLoc(gameStep);
    }

    private void SetTeams() {
        int firstCaptain = Permiscript.Instance.getCaptain();
        if (firstCaptain == 0) { 
            team1Tag = "Pathfinder Society";
            team1Image = pathfinderImage;
            team2Tag = "Aspis Consortium";
            team2Image = aspisImage;
        }
        else if (firstCaptain == 1) {
            team1Tag = "Aspis Consortium";
            team1Image = aspisImage;
            team2Tag = "Pathfinder Society";
            team2Image = pathfinderImage;
        }
        
        team1Icon.GetComponent<RawImage>().texture = team1Image;
        team2Icon.GetComponent<RawImage>().texture = team2Image;
        AssassinsIcon.GetComponent<RawImage>().texture = mantisImage;

    }

    private void InfoText() {
        switch (gameStep) {
            case 0:
                infoText = team1Tag + ", SELECT YOUR SPACES. DON'T LET THE PLAYERS SEE!";
                break;
            case 1:
                infoText = team2Tag + ", select your spaces.  Don't let the players see!";
                break;
            case 2:
                infoText = "Place the Assassin Card.  Don't let the players see!";
                break;
            case 3:
                infoText = "Pathfinder's Turn.";
                break;
            case 4:
                infoText = "Aspis Consortium's Turn";
                break;
            case 5:
                infoText = gameWinner + " wins!";
                break;
        }
        infoText = infoText.ToUpper();
    }

    public void Buttons(GameObject button) {
        // Team 1 selection turn
        if (gameStep == 0) {
            if (button.tag == "ClueCard" && team1Cards < team1TotalCards) {
                button.GetComponent<RawImage>().texture = team1Image;
                button.tag = team1Tag;
                team1Cards += 1;
            }
            else if (button.tag == team1Tag) {
                button.GetComponent<RawImage>().texture = BlankImage;
                button.tag = "ClueCard";
                team1Cards -= 1;
            }
        }
        // Team 2 Selection Turn
        else if (gameStep == 1) {
            if (button.tag == "ClueCard" && team2Cards < team2TotalCards) {
                button.GetComponent<RawImage>().texture = team2Image;
                button.tag = team2Tag;
                team2Cards += 1;
            }
            else if (button.tag == team2Tag) {
                button.GetComponent<RawImage>().texture = BlankImage;
                button.tag = "ClueCard";
                team2Cards -= 1;

            }
        }
        // Assassin Selection Turn
        else if (gameStep == 2) {
            if (button.tag == "ClueCard" && assassinTeamCards < 1) {
                button.GetComponent<RawImage>().texture = mantisImage;
                button.tag = "Assassin";
                assassinTeamCards += 1;
            }
            else if (button.tag == "Assassin") {
                button.GetComponent<RawImage>().texture = BlankImage;
                button.tag = "ClueCard";
                assassinTeamCards -= 1;

            }
        }
        // Team 1 Turn
        else if (gameStep == 3) {
            if (button.tag == team1Tag) {
                button.tag = "tagged";
                //set var
                button.GetComponent<RawImage>().texture = team1Image;
                button.GetComponentInChildren<TMP_Text>().text = "";
                team1Cards += 1;
                if (team1Cards >= 9) {
                    GameOver("Pathfinder Society");
                }
            }
            else if (button.tag == team2Tag) {
                button.tag = "tagged";
                button.GetComponent<RawImage>().texture = team2Image;
                button.GetComponentInChildren<TMP_Text>().text = "";
                team2Cards += 1;
                gameStep += 1;
            }
            else if (button.tag == "Assassin") {
                button.tag = "tagged";
                button.GetComponent<RawImage>().texture = mantisImage;
                button.GetComponentInChildren<TMP_Text>().text = "";
                assassinTeamCards += 1;
                GameOver("Aspis Consortium");
            }

            else if (button.tag == "ClueCard") {
                button.GetComponentInChildren<TMP_Text>().text = "";
                gameStep += 1;
            }
        }
        // Team 2 Turn
        else if (gameStep == 4) {
            if (button.tag == team1Tag) {
                button.tag = "tagged";
                button.GetComponent<RawImage>().texture = team1Image;
                button.GetComponentInChildren<TMP_Text>().text = "";
                team1Cards += 1;
                gameStep -= 1;
            }
            else if (button.tag == team2Tag) {
                button.tag = "tagged";
                button.GetComponent<RawImage>().texture = team2Image;
                button.GetComponentInChildren<TMP_Text>().text = "";
                team2Cards += 1;
                if (team2Cards >= 8) {
                    GameOver("Aspis Consortium");
                }
            }
            else if (button.tag == "Assassin") {
                button.tag = "tagged";
                button.GetComponent<RawImage>().texture = mantisImage;
                button.GetComponentInChildren<TMP_Text>().text = "";
                assassinTeamCards += 1;
                GameOver("Pathfinders");
            }
            else if (button.tag == "ClueCard") {
                button.GetComponentInChildren<TMP_Text>().text = "";
                gameStep -= 1;
            }
        }
    }

    private void GameOver(string winner) {
        gameWinner = winner;
        gameStep = 5;
        Destroy(PlayerFire.gameObject);
        GameOverScreen.SetActive(true);
        GameOverScreen.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "The " + gameWinner + " Wins!";
    }

    public void TurnButtons(int newgameStep) {
        if (gameStep == 0 || gameStep == 1 || gameStep == 2) {
            gameStep = newgameStep;
        }
        else if (gameStep == 3 || gameStep == 4) {
            newgameStep = newgameStep + 3;
            gameStep = newgameStep;
        }
        
    }

    public void RollInitiative() {
        if (team1Cards >= 9 && team2Cards >= 8 && assassinTeamCards >= 1) {
            foreach (GameObject clue in clueObjects) {
                clue.GetComponent<RawImage>().texture = BlankImage;
            }
            team1Cards = 0;
            team2Cards = 0;
            gameStep = 3;
            PopulateCards();
            EndTurnButton.SetActive(true);
            FireLoc(3);
            Destroy(AssassinsIcon);
            Destroy(InitativeButton);
        }  
    }

    public void EndTurn() {
        gameStep = (gameStep == 3 ? 4 : gameStep == 4 ? 3 : 3);
    }

    public void Menu() {
        if (MenuScreen.activeSelf == false) {
            MenuScreen.SetActive(true);
        }
        else MenuScreen.SetActive(false);
    }

    public void FireLoc(int loc){
        if (loc == 0 || loc == 3){
            PlayerFire.localPosition = new Vector3(-130, 1);
        }
        else if (loc == 1 || loc == 4) {
            PlayerFire.localPosition = new Vector3(130, 1);
        }
        else if (loc == 2) {
            PlayerFire.localPosition = new Vector3(0, 1);
        }
    }

    /// <summary>
    /// Create Random text on all of the cards.
    /// </summary>
    void PopulateCards() {
        foreach (GameObject clue in clueObjects) {
            int randomCard = UnityEngine.Random.Range(0, cluesText.Count);
            clue.GetComponentInChildren<TextMeshProUGUI>().text = cluesText[randomCard];
            cluesText.RemoveAt(randomCard);
        }
    }
}
