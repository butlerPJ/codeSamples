package com.example.administrator.defusethebomb;

import android.content.Intent;
import android.graphics.Typeface;
import android.os.CountDownTimer;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.ImageButton;
import android.widget.TextView;
import android.widget.Toast;
import android.widget.ToggleButton;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;

public class EasyGame extends AppCompatActivity {

    // Global variables
    Bomb bomb;
    // countdown timer
    private CountDownTimer timer;
    // counter display
    private TextView timeRemaining;
    // score display
    private TextView txtScore;
    // wires
    private ToggleButton blueWire;
    private ToggleButton redWire;
    private ToggleButton greenWire;
    // start button
    private ImageButton btnStart;
    // reset button
    private ImageButton btnReset;
    // intial start time on timer
    private final long INITIAL_TIME = 30000;
    // file object
    private final String FILE_NAME = "bomb.dat";
    // score
    private int score;
    // toast
    private Toast toast;
    // points awarded on defusal
    private long points;
    // remaining time at game win
    private long remainingTime;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_easy_game);
        // construct my toast object
        toast = Toast.makeText(this, "", Toast.LENGTH_LONG);
        // setup event listeners/handlers
        // get reference to buttons on interface
        // timeRemaining textView object
        timeRemaining = (TextView) findViewById(R.id.timeRemaining);
        // txtScore textview object
        txtScore = (TextView) findViewById(R.id.txtScore);
        // btnStart object
        btnStart = (ImageButton) findViewById(R.id.btnStart);
        btnStart.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                onStart(v);
            }
        });
        // btnReset object
        btnReset = (ImageButton) findViewById(R.id.btnReset);
        btnReset.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                onReset(v);
            }
        });

        // setup event listeners/handlers
        // get reference to wires on interface and assign a tag to each one
        blueWire = (ToggleButton) findViewById(R.id.blueWire);
        blueWire.setTag("0");
        blueWire.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                onWireCut(v);
            }
        });

        redWire = (ToggleButton) findViewById(R.id.redWire);
        redWire.setTag("1");
        redWire.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                onWireCut(v);
            }
        });

        greenWire = (ToggleButton) findViewById(R.id.greenWire);
        greenWire.setTag("2");
        greenWire.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                onWireCut(v);
            }
        });

        // construct typeFace object
        Typeface typeFace = Typeface.createFromAsset(getAssets(), "fonts/TickingTimebombBB.ttf");

        // apply typeFace object to appropriate views
        timeRemaining.setTypeface(typeFace);
        txtScore.setTypeface(typeFace);



        File file = getFileStreamPath(FILE_NAME);
        Log.d("pj", "check for file");
        if (file.exists()) {
            loadFile();
            // Log.d("pj", String.valueOf(bomb.getGameOver()));
            Log.d("pj", "file found, check for winning game");
            // // TODO: 11/12/2015 deal with double screen orientation change not saving data
                if (bomb.getGameOver()) {
                    Log.d("pj", "winning game found set up defaults");
                    // Log.d("pj", String.valueOf(bomb.getGameOver()));
                    createCountDownTimer();
                    onLoad();
                    disableWires();

                } else {
                    Log.d("pj", "winning game not found, repopulate timer");
                    // Log.d("pj", String.valueOf(bomb.getRemainingTime()));
                    // display the score at start
                    txtScore.setText((getResources().getString(R.string.scoreText)) + bomb.getScore());
                    timeRemaining.setText((getResources().getString(R.string.time_remaining) + bomb.getRemainingTime() / 1000));
                    // create the countDownTimer
                    reloadTimer();

                }

        } else {
            Log.d("pj", "file not found, create new bomb class");
            bomb = new Bomb();
            // display the score at start
            txtScore.setText((getResources().getString(R.string.scoreText)) + bomb.getScore());
            // create the countDownTimer
            createCountDownTimer();
            timeRemaining.setText(getRString(R.string.time_remaining) + INITIAL_TIME / 1000);
            // wires are disabled at first
            disableWires();
        }
    }

    //--------------------------------------------------------------------------------private methods

    private void createCountDownTimer() {
        // construct timer object
        timer = new CountDownTimer(INITIAL_TIME, 1000) {

            public void onTick(long millisUntilFinished) {

                timeRemaining.setText(getRString(R.string.time_remaining) + millisUntilFinished / 1000);
                remainingTime = millisUntilFinished;
            }

            public void onFinish() {
                // Log.d("pj", "create" + String.valueOf(bomb.getRemainingTime()));
                onKablooey();
            }

        };
    }

    private void subtractTime() {
        timer = new CountDownTimer(remainingTime - 12000, 1000) {

            public void onTick(long millisUntilFinished) {

                timeRemaining.setText(getRString(R.string.time_remaining) + millisUntilFinished / 1000);
                remainingTime = millisUntilFinished;
            }

            public void onFinish() {
                // Log.d("pj", "subtract" + String.valueOf(bomb.getRemainingTime()));
                onKablooey();
            }
        };
        timer.start();
    }

    private void reloadTimer() {
        timer = new CountDownTimer(bomb.getRemainingTime(), 1000) {

            public void onTick(long millisUntilFinished) {

                timeRemaining.setText(getRString(R.string.time_remaining) + millisUntilFinished / 1000);
                remainingTime = millisUntilFinished;
            }

            public void onFinish() {
                // Log.d("pj", "reload" + String.valueOf(bomb.getRemainingTime()));

                //// TODO: 10/12/2015 time provided, put an animated explosion here when timer hits 0
                // timeRemaining.setBackgroundResource(R.drawable.);
                // Log.d("pj", String.valueOf(bomb.getGameOver()));
                onKablooey();
            }
        };
        timer.start();

    }

    private void disableWires() {
        blueWire.setEnabled(false);
        redWire.setEnabled(false);
        greenWire.setEnabled(false);
    }

    private void win() {
        timer.cancel();
        // set the game state as not active
        bomb.setGameState(false);
        // Log.d("pj", "remaining time: " + remainingTime);
        // get remaining time from timer, divide by 10 and assign to points variable
        points = remainingTime/100;
        // add the points to the score
        score = Integer.parseInt(String.valueOf(points)) + bomb.getScore();
        bomb.setScore(score);
        // update the score
        txtScore.setText((getRString(R.string.scoreText)) + bomb.getScore());
        // disable the wires
        disableWires();
        btnStart.setEnabled(false);
        btnReset.setEnabled(true);
        bomb.setRemainingTime(remainingTime);
        toastMe(getRString(R.string.winner) + points);
    }

    // easy method for grabbing strings from strings.xml
    private String getRString(int str) {
        return getApplicationContext().getString(str);
    }

    private void onLoad() {
        btnStart.setEnabled(false);
        btnReset.setEnabled(true);
        timeRemaining.setText(getRString(R.string.time_remaining) + bomb.getRemainingTime() / 1000);

    }

    private void output() {
        // set the score
        txtScore.setText((getResources().getString(R.string.scoreText)) + bomb.getScore());
        // reload the timer
        reloadTimer();
    }

    @Override
    public void onPause() {
        super.onPause();
        try {
            // set data in bomb class on orientation change
            bomb.setRemainingTime(remainingTime);
            bomb.setScore(score);
            // construct IO objects
            FileOutputStream outFileStream = openFileOutput(FILE_NAME, MODE_PRIVATE);
            ObjectOutputStream outObjectStream = new ObjectOutputStream(outFileStream);

            // write values of primitive data to the stream
            outObjectStream.writeObject(bomb);

            // make sure all data written to the file
            outObjectStream.flush();
            outObjectStream.close();

        } catch (Exception e) {
            Log.d("PJ", "!!! EXCEPTION", e);
        }
    }

    private void loadFile() {

        try {
            // construct IO objects to read data
            FileInputStream inFileStream = openFileInput(FILE_NAME);
            ObjectInputStream inObjectStream = new ObjectInputStream(inFileStream);

            // read values from the stream
            bomb = (Bomb)inObjectStream.readObject();

            // close stream
            inObjectStream.close();


        } catch (Exception e) {
            Log.d("PJ", "!!! EXCEPTION", e);
        } finally {
            txtScore.setText((getRString(R.string.scoreText)) + bomb.getScore());
            timeRemaining.setText(getRString(R.string.time_remaining) + bomb.getRemainingTime() / 1000);
        }
    }

    private void onKablooey() {
        // display that bomb has exploded
        timeRemaining.setText(getRString(R.string.kablooey));
        // reset the score to 0 upon explosion
        bomb.setScore(0);
        //set the remaining time
        bomb.setRemainingTime(0);
        // display updated score
        txtScore.setText((getRString(R.string.scoreText)) + bomb.getScore());
        disableWires();
        btnReset.setEnabled(true);
        btnStart.setEnabled(false);
        bomb.setGameState(false);
    }
    //-----------------------------------------------------------------------------------public methods

    public void onBackPressed() {
        finish();
    }

    public void toastMe(String msg) {
        toast.setText(msg);
        toast.show();
    }

    public void onWireCut (View v) {
        // wire has been cut - disable button on click
        v.setEnabled(false);
        int whichButton = Integer.parseInt(String.valueOf(v.getTag()));
        // check to see if this is the right wire
        if (bomb.selected(whichButton)) {
            // check if the game is over
            if (bomb.getGameOver()) {
                win();
            }
        } else {
            timer.cancel();
            subtractTime();
        }
    }

    public void onStart (View v) {
        // set the state of the game to active
        bomb.setGameState(true);
        // disable the buttons
        btnStart.setEnabled(false);
        btnReset.setEnabled(false);
        // start the timer
        timer.start();
        // enable the wires
        redWire.setEnabled(true);
        blueWire.setEnabled(true);
        greenWire.setEnabled(true);

    }

    public void onReset (View v) {
        reset();
    }

    public void reset() {
        // set the wires back to uncut state
        blueWire.setChecked(false);
        redWire.setChecked(false);
        greenWire.setChecked(false);
        // enable the start button
        btnStart.setEnabled(true);
        // reset the timer
        createCountDownTimer();
        // reset the time display
        timeRemaining.setText(getRString(R.string.time_reset));
        bomb.setGameState(false);
        bomb.reset();
    }

/*  Following 2 methods were replaced with onWireCut
    public void onRedWire (View v){
        // wire has been cut - disable button on click
        redWire.setEnabled(false);
        // variable to pass selected wire to the bomb.selected method
        boolean thisOne = redWire.isChecked();
        // check to see if this is the right wire
        if (bomb.selected(2)) {
            // check if the game is over
            if (bomb.getGameOver()) {
                win();
            }
        }
    }

    public void onGreenWire (View v){
        // wire has been cut - disable button on click
        greenWire.setEnabled(false);
        // variable to pass selected wire to the bomb.selected method
        boolean thisOne = greenWire.isChecked();
        // check to see if this is the right wire
        if (bomb.selected(3)) {
            // check if the game is over
            if (bomb.getGameOver()) {
                win();
            }
        }

    }*/


}
