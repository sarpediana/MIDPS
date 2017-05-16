package com.sd.jocdememorie;

import android.graphics.Color;
import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;

import java.util.Arrays;
import java.util.Collections;

public class MainActivity extends AppCompatActivity {
    TextView tv_p1, tv_p2;
    ImageView iv_11, iv_12, iv_13, iv_14,iv_21, iv_22, iv_23, iv_24,iv_31, iv_32, iv_33, iv_34;

    //tabel pentru imaginii
    Integer[] cardsArray = {101,102, 103, 104, 105, 106, 201,202, 203, 204, 205, 206 };

    int image101, image102, image103,  image104, image105,image106, image201, image202,
            image203, image204, image205,image206;

    int firstCard, secondCard;
    int clickedFirst, clickedSecond;
    int cardNumber = 1;

    int turn = 1;
    int playerPoints = 0, cpuPoints = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        tv_p1 = (TextView) findViewById(R.id.tv_p1);
        tv_p2 = (TextView) findViewById(R.id.tv_p2);

        iv_11 = (ImageView) findViewById(R.id.iv_11);
        iv_12 = (ImageView) findViewById(R.id.iv_12);
        iv_13 = (ImageView) findViewById(R.id.iv_13);
        iv_14 = (ImageView) findViewById(R.id.iv_14);

        iv_21 = (ImageView) findViewById(R.id.iv_21);
        iv_22 = (ImageView) findViewById(R.id.iv_22);
        iv_23 = (ImageView) findViewById(R.id.iv_23);
        iv_24 = (ImageView) findViewById(R.id.iv_24);

        iv_31 = (ImageView) findViewById(R.id.iv_31);
        iv_32 = (ImageView) findViewById(R.id.iv_32);
        iv_33 = (ImageView) findViewById(R.id.iv_33);
        iv_34 = (ImageView) findViewById(R.id.iv_34);


        iv_11.setTag("0");
        iv_11.setTag("1");
        iv_11.setTag("2");
        iv_11.setTag("3");

        iv_21.setTag("4");
        iv_21.setTag("5");
        iv_21.setTag("6");
        iv_21.setTag("7");

        iv_31.setTag("8");
        iv_31.setTag("9");
        iv_31.setTag("10");
        iv_31.setTag("11");

        frontOfCardsResources();

        Collections.shuffle(Arrays.asList(cardsArray));


        //changing the color of the second player
        tv_p2.setTextColor(Color.GRAY);

        iv_11.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                int theCard = Integer.parseInt((String) view.getTag());
                doStuff(iv_11, theCard);
            }
        });

        iv_12.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                int theCard = Integer.parseInt((String) view.getTag());
                doStuff(iv_12, theCard);
            }
        });

        iv_13.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                int theCard = Integer.parseInt((String) view.getTag());
                doStuff(iv_13, theCard);
            }
        });

        iv_14.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                int theCard = Integer.parseInt((String) view.getTag());
                doStuff(iv_14, theCard);
            }
        });

        iv_21.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                int theCard = Integer.parseInt((String) view.getTag());
                doStuff(iv_21, theCard);
            }
        });

        iv_22.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                int theCard = Integer.parseInt((String) view.getTag());
                doStuff(iv_22, theCard);
            }
        });

        iv_23.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                int theCard = Integer.parseInt((String) view.getTag());
                doStuff(iv_23, theCard);
            }
        });

        iv_24.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                int theCard = Integer.parseInt((String) view.getTag());
                doStuff(iv_24, theCard);
            }
        });

        iv_31.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                int theCard = Integer.parseInt((String) view.getTag());
                doStuff(iv_31, theCard);
            }
        });

        iv_32.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                int theCard = Integer.parseInt((String) view.getTag());
                doStuff(iv_32, theCard);
            }
        });

        iv_33.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                int theCard = Integer.parseInt((String) view.getTag());
                doStuff(iv_33, theCard);
            }
        });

        iv_34.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                int theCard = Integer.parseInt((String) view.getTag());
                doStuff(iv_34, theCard);
            }
        });
        private void doStuff(ImageView iv, int card)
    {
        if(cardsArray[card] == 101)
        {
            iv_11.setImageResource(image101);
        }
        else if (cardsArray[card] == 102 )
        {
            iv_11.setImageResource(image102);
        }
        else if (cardsArray[card] == 103 )
        {
            iv_11.setImageResource(image103);
        }
        else if (cardsArray[card] == 104 )
        {
            iv_11.setImageResource(image104);
        }
        else if (cardsArray[card] == 105 )
        {
            iv_11.setImageResource(image105);
        }
        else if (cardsArray[card] == 106 )
        {
            iv_11.setImageResource(image106);
        }
        else if (cardsArray[card] == 201 )
        {
            iv_11.setImageResource(image201);
        }
        else if (cardsArray[card] == 202 )
        {
            iv_11.setImageResource(image202);
        }
        else if (cardsArray[card] == 203 )
        {
            iv_11.setImageResource(image203);
        }
        else if (cardsArray[card] == 204 )
        {
            iv_11.setImageResource(image204);
        }
        else if (cardsArray[card] == 205 )
        {
            iv_11.setImageResource(image205);
        }
        else if (cardsArray[card] == 206 )
        {
            iv_11.setImageResource(image206);
        }
        // cauta imaginea selectata
        if(cardNumber == 1)
        {
            firstCard = cardsArray[card];
            if(firstCard > 200 )
            {
                firstCard = firstCard - 100;

            }
            cardNumber = 2;
            clickedFirst = card;

            iv.setEnabled(false);
        } else if (cardNumber == 2)
        {
            secondCard = cardsArray[card];
            if(secondCard > 200 )
            {
                secondCard = secondCard - 100;
            }
            cardNumber = 1;
            clickedSecond= card;

            iv_11.setEnabled(false);
            iv_12.setEnabled(false);
            iv_13.setEnabled(false);
            iv_14.setEnabled(false);
            iv_21.setEnabled(false);
            iv_22.setEnabled(false);
            iv_23.setEnabled(false);
            iv_24.setEnabled(false);
            iv_31.setEnabled(false);
            iv_32.setEnabled(false);
            iv_33.setEnabled(false);
            iv_34.setEnabled(false);

            Handler handler = new Handler();
            handler.postDelayed(new Runnable() {
                @Override
                public void run() {
                    calculate ();
                }
            }, 1000);

        }


    }
        private void  frontOfCardsResources()
    {
        image101 = R.drawable.ciine;
        image102 = R.drawable.iep;
        image103 = R.drawable.pur;
        image104 = R.drawable.ham;
        image105 = R.drawable.Tom;
        image106 = R.drawable.vever;

        image101 = R.drawable.ic_ciine;
        image102 = R.drawable.ic_iep;
        image103 = R.drawable.ic_pur;
        image104 = R.drawable.ic_ham;
        image105 = R.drawable.ic_tom;
        image106 = R.drawable.ic_vever;


    }



    }
}
