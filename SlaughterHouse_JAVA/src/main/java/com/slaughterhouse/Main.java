package com.slaughterhouse;

import com.slaughterhouse.DAO.AnimalRepository;
import com.slaughterhouse.Entities.Animal;
import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.Bean;

import java.sql.Timestamp;

@SpringBootApplication
public class Main {

  public static void main(String[] args) {
    SpringApplication.run(Main.class, args);
  }


//  @Bean
//  CommandLineRunner seedAndRead(AnimalRepository animals) {
//    return args -> {
//      // create + save
//      Animal a = new Animal();
//      a.setRegistrationNumber("SK-105");
//      a.setWeight(122.4);
//      a.setArrivalDate(Timestamp.valueOf(java.time.LocalDateTime.now())); // or
//      animals.save(a);
//
//      // read back
//      System.out.println("=== Animals in DB ===");
//      animals.findAll().forEach(an ->
//          System.out.printf("id=%d reg=%s weight=%.2f%n",
//              an.getId(), an.getRegistrationNumber(), an.getWeight()));
//    };
//  }


}
