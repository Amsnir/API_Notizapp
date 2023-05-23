package com.example.api_notizapp;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
public class NotizController {

    @Autowired
    NotizService notizService;

    @RequestMapping(method = RequestMethod.POST, value="/addNotiz")
    public String addNotiz(@RequestBody Notiz notiz) {
        notizService.addNotiz(notiz);
        String response = "{\"success\": true, \"message\": Notiz has been added successfully.}";
        return response;
    }

    @DeleteMapping(value="/deleteNotiz/{id}")
    public String deleteNotiz(@PathVariable String id) {
        notizService.deleteNotiz(id);
        String response = "{\"success\": true, \"message\": Notiz has been deleted successfully.}";
        return response;
    }

    @RequestMapping(method = RequestMethod.PUT, value="/editNotiz/{id}")
    public String editNotiz(@RequestBody Notiz notiz, @PathVariable String id) {
        notizService.editNotiz(id, notiz);
        String response = "{\"success\": true, \"message\": Notiz has been edited successfully.}";
        return response;
    }

    @RequestMapping(method = RequestMethod.GET, value = "/Notiz")
    public List<Notiz> getallInfo() {return notizService.getAll();}

    @RequestMapping(method = RequestMethod.GET, value = "/status")
    public String getStatus() {
        return "Das Service ist verfügbar!";
    }

}
