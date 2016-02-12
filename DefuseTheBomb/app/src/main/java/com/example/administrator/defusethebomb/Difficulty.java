package com.example.administrator.defusethebomb;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.ImageButton;
import android.widget.Toast;

public class Difficulty extends AppCompatActivity {

    // global variables#
    ImageButton btnEasy;
    ImageButton btnMedium;
    ImageButton btnHard;
    Toast toast;



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.difficulty);

        btnEasy = (ImageButton) findViewById(R.id.btnEasy);
        btnEasy.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                onEasyGame(v);
            }
        });

        btnMedium = (ImageButton) findViewById(R.id.btnMedium);
        btnMedium.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                onMediumGame(v);
            }
        });

        btnHard = (ImageButton) findViewById(R.id.btnHard);
        btnHard.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                onHardGame(v);
            }
        });
        // construct my toast object
        toast = Toast.makeText(this, "", Toast.LENGTH_LONG);

    }

    public void onBackPressed() {
        super.onBackPressed();
    }

    public void toastMe(String msg) {
        toast.setText(msg);
        toast.show();
    }

    public void onEasyGame (View v){
        startActivity(new Intent("com.example.administrator.defusethebomb.EasyGame"));
        finish();
    }

   public void onMediumGame (View v){
       toastMe(getResources().getString(R.string.medium));
    }

    public void onHardGame (View v){
        toastMe(getResources().getString(R.string.hard));
    }

}
