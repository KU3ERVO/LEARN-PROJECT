package com.example.listadosymenus.ejercicios;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.TextView;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import com.example.listadosymenus.R;

public class Ej62 extends AppCompatActivity {

    ListView lv;
    TextView tv;

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.actividad2_layout);

        lv = findViewById(R.id.listViewPaises);
        tv = findViewById(R.id.textViewPaisSeleccionado);

        String[] videogames = {"METROID", "ZELDA", "BAYONETTA", "HOLLOW KNIGHT",
                "DARK SOULS", "BLASPHEMOUS", "SMASH BROS", "BATMAN ARKHAM", "LEAGUE", "ANGEL"};

        ArrayAdapter<String> adp = new ArrayAdapter<>(
                this, R.layout.list_item_videogames, R.id.textViewItemVideogame, videogames);

        lv.setAdapter(adp);

        lv.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                String elemento = (String) parent.getItemAtPosition(position);
                tv.setText(elemento);
            }
        });
    }
}

