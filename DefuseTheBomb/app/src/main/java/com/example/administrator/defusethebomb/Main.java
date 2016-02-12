package com.example.administrator.defusethebomb;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;


public class Main extends AppCompatActivity {

    // global variables
    ImageButton btnPlayGame;
    ImageButton btnInstructions;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        // setup event listeners/handlers
        // get reference to buttons on interface
        btnPlayGame = (ImageButton) findViewById(R.id.btnPlayGame);
        btnPlayGame.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                onPlayGame(v);
            }
        });
        btnInstructions = (ImageButton) findViewById(R.id.btnInstructions);
        btnInstructions.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                onInstruct(v);
            }
        });

    }

    public void onPlayGame (View v){
        startActivity(new Intent("com.example.administrator.defusethebomb.Difficulty"));
        finish();
    }

    public void onInstruct (View v){
        startActivity(new Intent("com.example.administrator.defusethebomb.Instructions"));
        finish();
    }


}
