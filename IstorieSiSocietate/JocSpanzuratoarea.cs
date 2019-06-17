using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Media;
using System.Drawing;
using System.Windows.Forms;

namespace IstorieSiSocietate
{
    public partial class JocSpanzuratoarea : Form
    {
        enum HangParts
        {
            None,
            Stalp,
            Rope,
            Cap,
            Corp,
            ManaS,
            ManaD,
            LegS,
            LegD
        }

        enum SoundType
        {
            Good,
            Bad,
            Win,
            Lose
        }

        struct WordPair
        {
            public readonly string hint;
            public readonly string Guess;

            public WordPair(string hint, string guess)
            {
                this.hint = hint;
                this.Guess = guess;
            }
        }

        //List<Label> CharLabels = new List<Label>();

        #region Grafica

        Pen p, pRope;
        HangParts ToDraw;

        #endregion

        #region Declarare Dimensiuni

        //Dimensiuni stalp
        Point StalpVerBottom;
        Point StalpVerTop;
        Point StalpHorRight;
        Point StalpHorLeft;

        //Dimensiuni funie
        Point RopeTop;
        Point RopeBottom;
        const int RopeLength = 30;

        //Dimensiuni cap
        const int CapDiametru = 40;
        int CapBoundRectX;

        //Dimensiuni corp
        int CorpBoundRectY;
        int CorpSize;

        #endregion

        private readonly WordPair[] wordBank = new WordPair[]
        {
            new WordPair("Aviator", "VASILE CRAIU"),
            new WordPair("Revoluționar", "TUDOR VLADIMIRESCU"),
            new WordPair("Marele Război", "PRIMUL RAZBOI MONDIAL"),
            new WordPair("Distincție militară", "ORDINUL MIHAI VITEAZUL"),
            new WordPair("Avion", "NIEUPORT")
        };

        WordPair pairToGuess;

        readonly List<Label> listCharLabels = new List<Label>();

        public JocSpanzuratoarea()
        {
            InitializeComponent();
        }

        private void SoundPlay(SoundType type)
        {
            using (SoundPlayer soundPlayer = new SoundPlayer())
            {
                switch (type)
                {
                    case SoundType.Good:
                        soundPlayer.SoundLocation = "Sounds/Spanzuratoarea/SpCorect.wav";
                        break;

                    case SoundType.Bad:
                        soundPlayer.SoundLocation = "Sounds/Spanzuratoarea/SpIncorect.wav";
                        break;

                    case SoundType.Win:
                        soundPlayer.SoundLocation = "Sounds/Spanzuratoarea/SpWin.wav";
                        break;

                    case SoundType.Lose:
                        soundPlayer.SoundLocation = "Sounds/Spanzuratoarea/SpLose.wav";
                        break;
                }

                soundPlayer.Play();
            }
        }
        private void CheckChar(char charClicked)
        {
            if (pairToGuess.Guess.Contains(charClicked.ToString()))
            {
                char[] guessChars = pairToGuess.Guess.ToCharArray();

                for (int i = 0; i < guessChars.Length; i++)
                {
                    if (guessChars[i] == charClicked)
                    {
                        listCharLabels[i].Text = charClicked.ToString();
                        textGLeft.Text = (Int32.Parse(textGLeft.Text) - 1).ToString();
                    }
                }

                SoundPlay(SoundType.Good);

                labelChState.ForeColor = Color.Green;
                labelChState.Text = "Bravo!";
            }
            else
            {
                ToDraw++;
                PicBoxHang.Invalidate();
                SoundPlay(SoundType.Bad);
                textTryLeft.Text = (Int32.Parse(textTryLeft.Text) - 1).ToString();

                labelChState.ForeColor = Color.Red;
                labelChState.Text = "Oops!";
            }

            CheckEndGame();
        }

        private void CheckEndGame()
        {
            if (textGLeft.Text == "0")
            {
                SoundPlay(SoundType.Win);
                EndGame();
            }

            if(textTryLeft.Text == "0")
            {
                SoundPlay(SoundType.Lose);

                #region Afisare caractere ramase
                for (int i=0; i<listCharLabels.Count; i++)
                {
                    if(listCharLabels[i].Text == "__")
                    {
                        listCharLabels[i].ForeColor = Color.Red;
                        listCharLabels[i].Text = pairToGuess.Guess.ToCharArray()[i].ToString();
                    }
                }
                #endregion

                EndGame();
            }
        }

        private void NewGame()
        {
            labelChState.Text = null;
            AddBtn();

            ToDraw = HangParts.None;
            PicBoxHang.Invalidate();
            textTryLeft.Text = "8";

            pairToGuess = wordBank[new Random().Next(0, wordBank.Length)];

            labelHint.Text = pairToGuess.hint;

            AddChars();

            btnGameStart.Enabled = false;
        }

        private void EndGame()
        {
            foreach (Control ctrl in FlowPanelButtons.Controls)
            {
                ctrl.Enabled = false;
            }

            btnGameStart.Enabled = true;
        }

        private void AddChars()
        {
            groupChars.Controls.Clear();
            listCharLabels.Clear();

            char[] wordChars = pairToGuess.Guess.ToCharArray();
            int size = (int)(groupChars.Width / 1.5 / wordChars.Length);
            int chguess=0;

            Label label;
            for (int i = 0; i < wordChars.Length; i++)
            {
                label = new Label();

                if (wordChars[i] != ' ')
                {
                    label.Text = "__";
                    chguess++;
                }
                else label.Text = "  ";

                label.Location = new Point(100 + i * size, groupChars.Height / 2 - 5);
                label.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);
                label.Parent = groupChars;
                label.BringToFront();

                listCharLabels.Add(label);
            }

            textGLeft.Text = chguess.ToString();
        }

        private void AddBtn()
        {
            FlowPanelButtons.Controls.Clear();

            for (int i = 'A'; i <= 'Z'; i++)
            {
                Button btn = new Button
                {
                    Text = ((char)i).ToString(),
                    Parent = FlowPanelButtons,
                    Font = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold),
                    Size = new Size(40, 40),
                    BackColor = Color.CadetBlue
                };
                btn.Click += FlowBtn_Click;
            }
        }

        private void JocSpanzuratoarea_Load(object sender, EventArgs e)
        {
            #region Setare Creioane

            p = new Pen(Color.Blue, 20);
            pRope = new Pen(Color.Blue, 5);

            #endregion

            #region Setare Dimensiuni

            //Dimensiuni stalp
            StalpVerBottom = new Point(PicBoxHang.Width - 30, PicBoxHang.Height - 15);
            StalpVerTop = new Point(StalpVerBottom.X, 30);
            StalpHorRight = new Point(PicBoxHang.Width - 20, 50);
            StalpHorLeft = new Point(50, StalpHorRight.Y);

            //Dimensiuni funie
            RopeTop = new Point((StalpHorRight.X + StalpHorLeft.X) / 3, StalpHorLeft.Y);
            RopeBottom = new Point(RopeTop.X, RopeTop.Y + RopeLength);

            //Dimensiuni cap
            CapBoundRectX = RopeBottom.X - CapDiametru / 2;

            //Dimensiuni corp
            CorpBoundRectY = RopeBottom.Y + CapDiametru;
            CorpSize = (StalpVerBottom.Y - StalpVerTop.Y) / 2;

            #endregion

            labelHint.Text = null;
            labelChState.Text = null;
            textGLeft.Text = null;
            textTryLeft.Text = null;
        }

        private void PicBoxHang_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            for (HangParts part = 0; part <= ToDraw; part++)
            {
                switch (part)
                {
                    case HangParts.LegD:
                        graphics.DrawCurve(pRope,
                            new[]
                            {
                            new Point(CapBoundRectX + CapDiametru - 8, CorpBoundRectY + CorpSize - 15),
                            new Point(CapBoundRectX + CapDiametru + 30, CorpBoundRectY + CorpSize - 5),
                            new Point(CapBoundRectX + CapDiametru + 30, CorpBoundRectY + CorpSize),
                            new Point(CapBoundRectX + CapDiametru - 5, CorpBoundRectY + CorpSize - 25)
                            });
                        break;

                    case HangParts.LegS:
                        graphics.DrawCurve(pRope,
                            new[]
                            {
                            new Point(CapBoundRectX + 8, CorpBoundRectY + CorpSize - 15),
                            new Point(CapBoundRectX - 30, CorpBoundRectY + CorpSize - 5),
                            new Point(CapBoundRectX - 30, CorpBoundRectY + CorpSize),
                            new Point(CapBoundRectX + 5, CorpBoundRectY + CorpSize - 25)
                            });
                        break;

                    case HangParts.ManaD:
                        graphics.DrawCurve(pRope,
                            new[]
                            {
                            new Point(CapBoundRectX + CapDiametru - 8, CorpBoundRectY + 15),
                            new Point(CapBoundRectX + CapDiametru + 30, CorpBoundRectY + 30),
                            new Point(CapBoundRectX + CapDiametru + 30, CorpBoundRectY + 20),
                            new Point(CapBoundRectX + CapDiametru - 5, CorpBoundRectY + 25)
                            });
                        break;

                    case HangParts.ManaS:
                        graphics.DrawCurve(pRope,
                            new[]
                            {
                           new Point(CapBoundRectX + 8, CorpBoundRectY + 15),
                           new Point(CapBoundRectX - 30, CorpBoundRectY + 30),
                           new Point(CapBoundRectX - 30, CorpBoundRectY + 20),
                           new Point(CapBoundRectX + 5, CorpBoundRectY + 25),
                            });
                        break;

                    case HangParts.Corp:
                        graphics.DrawEllipse(pRope, new Rectangle(new Point(CapBoundRectX, CorpBoundRectY), new Size(CapDiametru, CorpSize)));
                        break;

                    case HangParts.Cap:
                        graphics.DrawEllipse(pRope, new Rectangle(new Point(CapBoundRectX, RopeBottom.Y), new Size(CapDiametru, CapDiametru)));
                        graphics.FillRectangles(new SolidBrush(Color.Crimson),
                            new[]
                            {
                            new Rectangle(new Point(CapBoundRectX + 10, RopeBottom.Y + 10), new Size(6, 6)),                    //Ochi stang
                            new Rectangle(new Point(CapBoundRectX + CapDiametru - 10 - 6, RopeBottom.Y + 10), new Size(6, 6)),  //Ochi drept
                            new Rectangle(new Point(RopeBottom.X - 5/2, RopeBottom.Y + CapDiametru/2), new Size(5, 5)),         //Nas
                            new Rectangle(new Point(RopeBottom.X - 10, RopeBottom.Y + CapDiametru/2 + 10), new Size(20, 5))     //Gura
                            });
                        break;

                    case HangParts.Rope:
                        graphics.DrawLine(pRope, RopeTop, RopeBottom);
                        break;

                    case HangParts.Stalp:
                        graphics.DrawLine(p, StalpVerBottom, StalpVerTop);
                        graphics.DrawLine(p, StalpHorRight, StalpHorLeft);
                        break;
                }
            }
        }

        private void BtnGameStart_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void FlowBtn_Click(object sender, EventArgs e)
        {
            using (Button btn = sender as Button)
            {
                CheckChar(charClicked: btn.Text.ToCharArray()[0]);
            }
        }
    }
}
