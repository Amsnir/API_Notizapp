package com.example.api_notizapp;

import org.springframework.data.mongodb.repository.MongoRepository;

public interface NotizRepository extends MongoRepository<Notiz, String> {

    public Notiz findByTitle(String title);
}
