package com.example.api_notizapp;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.Collections;
import java.util.List;
import java.util.Optional;

@Service
public class NotizService {

    @Autowired
    NotizRepository notizRepository;

    public void addNotiz(Notiz notiz) {this.notizRepository.save(notiz);}

    public void deleteNotiz(String id) {this.notizRepository.deleteAllById(Collections.singleton(id));}

    public void editNotiz(String id, Notiz notiz) {
        this.notizRepository.findById(id);
        notiz.setId(id);
        this.notizRepository.save(notiz);
    }

    public List<Notiz> getAll() {return (List<Notiz>)this.notizRepository.findAll();}
}
