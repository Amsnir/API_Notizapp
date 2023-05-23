package com.example.api_notizapp;

import com.fasterxml.jackson.annotation.JsonFormat;
import org.springframework.data.annotation.Id;

import java.lang.annotation.Inherited;
import java.time.LocalDate;
import java.util.Date;

public class Notiz {
    @Id
    public String id;
    public String title;
    @JsonFormat(pattern="yyyy-MM-dd")
    public LocalDate datum = LocalDate.now();
    public String inhalt;


    public void setId(String id) {
        this.id = id;
    }
    public String getId() {
        return id;
    }

    public void setTitle(String title) {
        this.title = title;
    }
    public String getTitle() {
        return title;
    }

    public void setDatum(LocalDate datum) {
        this.datum = datum;
    }
    public LocalDate getDatum() {
        return datum;
    }

    public void setInhalt(String inhalt) {
        this.inhalt = inhalt;
    }
    public String getInhalt() {
        return inhalt;
    }



    public Notiz(){}

    public Notiz(String id, String title, LocalDate datum, String inhalt){
        this.id = id;
        this.title = title;
        this.datum = datum;
        this.inhalt = inhalt;
    }

    @Override
    public String toString() {
        return String.format(
                "Notiz[id=%s, title='%s', datum='%s', inhalt='%s']",
                id, title, datum, inhalt);
    }
}
