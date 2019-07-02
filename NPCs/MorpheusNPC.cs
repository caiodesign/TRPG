using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace TRPG.NPCs
{
    // [AutoloadHead] and npc.townNPC are extremely important and absolutely both necessary for any Town NPC to work at all.
    [AutoloadHead]
    public class MorpheusNPC : ModNPC
    {
        public override bool Autoload(ref string name)
        {
            name = "Morpheus";
            return mod.Properties.Autoload;
        }

        public override void SetStaticDefaults()
        {
            // DisplayName automatically assigned from .lang files, but the commented line below is the normal approach.
            DisplayName.SetDefault("Morpheus");
            Main.npcFrameCount[npc.type] = 25;
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 4;
            NPCID.Sets.DangerDetectRange[npc.type] = 700;
            NPCID.Sets.AttackType[npc.type] = 0;
            NPCID.Sets.AttackTime[npc.type] = 90;
            NPCID.Sets.AttackAverageChance[npc.type] = 30;
            NPCID.Sets.HatOffsetY[npc.type] = 4;
        }

        public override void SetDefaults()
        {
            npc.townNPC = true; //This defines if the npc is a town Npc or not
            npc.friendly = true;  //this defines if the npc can hur you or not()
            npc.width = 18; //the npc sprite width
            npc.height = 46;  //the npc sprite height
            npc.aiStyle = 7; //this is the npc ai style, 7 is Pasive Ai
            npc.defense = 25;  //the npc defense
            npc.lifeMax = 250;// the npc life
            npc.HitSound = SoundID.NPCHit1;  //the npc sound when is hit
            npc.DeathSound = SoundID.NPCDeath1;  //the npc sound when he dies
            npc.knockBackResist = 0.5f;  //the npc knockback resistance
            Main.npcFrameCount[npc.type] = 25; //this defines how many frames the npc sprite sheet has
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 4;
            NPCID.Sets.DangerDetectRange[npc.type] = 150; //this defines the npc danger detect range
            NPCID.Sets.AttackType[npc.type] = 3; //this is the attack type,  0 (throwing), 1 (shooting), or 2 (magic). 3 (melee) 
            NPCID.Sets.AttackTime[npc.type] = 30; //this defines the npc attack speed
            NPCID.Sets.AttackAverageChance[npc.type] = 10;//this defines the npc atack chance
            NPCID.Sets.HatOffsetY[npc.type] = 4; //this defines the party hat position
            animationType = NPCID.Guide;  //this copy the guide animation
        }


        public override void HitEffect(int hitDirection, double damage)
        {
            int num = npc.life > 0 ? 1 : 5;
            for (int k = 0; k < num; k++)
            {
                Dust.NewDust(npc.position, npc.width, npc.height, mod.DustType("Sparkle"));
            }
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            return true;

        }

        public override bool CheckConditions(int left, int right, int top, int bottom)    //Allows you to define special conditions required for this town NPC's house
        {
            return true;  //so when a house is available the npc will  spawn
        }

        public override void SetChatButtons(ref string button, ref string button2)  //Allows you to set the text for the buttons that appear on this town NPC's chat window. 
        {
            button = "Choose your destiny";   //this defines the buy button name
        }

        public override void OnChatButtonClicked(bool firstButton, ref bool openShop) //Allows you to make something happen whenever a button is clicked on this town NPC's chat window. The firstButton parameter tells whether the first button or second button (button and button2 from SetChatButtons) was clicked. Set the shop parameter to true to open this NPC's shop.
        {

            if (firstButton)
            {
                openShop = true;   //so when you click on buy button opens the shop
            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot)       //Allows you to add items to this town NPC's shop. Add an item by setting the defaults of shop.item[nextSlot] then incrementing nextSlot.
        {
            shop.item[nextSlot].SetDefaults(ItemID.IronskinPotion);
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("Broadsword"));  //this is an example of how to add a modded item
            nextSlot++;

        }


        public override string TownNPCName()
        {
            return "Morpheus";
        }

         
		// Consider using this alternate approach to choosing a random thing. Very useful for a variety of use cases.
		// The WeightedRandom class needs "using Terraria.Utilities;" to use
		public override string GetChat()
		{
            WeightedRandom<string> chat = new WeightedRandom<string>();
            string start = "Unfortunately, no one can be told ";
            string end = " You have to see it for yourself.";
			chat.Add(start + "what The Matrix is." + end);
            chat.Add(start + "what Terraria is." + end);
            chat.Add(start + "what a meme is." + end);
            chat.Add(start + "what good acting is." + end);
            chat.Add(start + "what Speed is." + end);
            chat.Add(start + "what good acting is." + end);
            chat.Add(start + "what Bill and Ted's Excellent Adventure is." + end);
            chat.Add(start + "what Keanu Reeves is." + end);
            chat.Add(start + "what John Wick is." + end);
            chat.Add(start + "what ( ͡° ͜ʖ ͡°) is." + end);
            chat.Add(start + "what (>'-')> <('-'<) ^('-')^ v('-')v (>'-')> (^-^) is." + end);
            chat.Add(start + "what the Youtube algorithm is. You have to be demonitized for yourself.");
            chat.Add(start + "what an Elytra is." + end);
            chat.Add(start + "what happened to Rayman's limbs." + end);
            chat.Add(start + "what Festivus is." + end);
            chat.Add(start + "what Undertale is." + end);
            chat.Add(start + "what Amnesia: The Dark Descent is." + end);
            chat.Add(start + "what pneumonoultramicroscopicsilicovolcanoconiosis is." + end);
            chat.Add(start + "what weaboos are." + end);
            chat.Add(start + "what the Beatles meant in I Am The Walrus. You have to smoke it for yourself.");
            chat.Add(start + "what what the fox says. You have to hear it for yourself.");
            chat.Add(start + "what the Laplace Transform is." + end);
            chat.Add(start + "what deus ex machina is. It has to spontaneously come from nowhere.");
            chat.Add(start + "how hot Sandra Bullock was in the 90s." + end);
            chat.Add(start + "how to make a mod." + end);
            chat.Add(start + "how much wood would a woodchuck chuck if a woodchuck could chuck wood." + end);
            chat.Add(start + "how many licks it takes to get to the tootsie roll center of a tootsie pop ." + end);
            chat.Add(start + "how magnets work." + end);
            chat.Add(start + "where to find a boat. You have to see if you can find it for yourself.");
            chat.Add(start + "where in the world Carmen Sandiego is. You have to find her for yourself.");
            chat.Add(start + "where Waldo is." + end);
            chat.Add(start + "why Waldo is hiding." + end);

            //chat.Add("This message has a weight of 5, meaning it appears 5 times more often.", 5.0);
            //chat.Add("This message has a weight of 0.1, meaning it appears 10 times as rare.", 0.1);
            return chat; // chat is implicitly cast to a string. You can also do "return chat.Get();" if that makes you feel better
		}
		
        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 20;
            knockback = 4f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 30;
            randExtraCooldown = 30;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 12f;
            randomOffset = 2f;
        }
    }
}
