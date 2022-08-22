# Supernatural-Inheritance---Codecademy

This repository holds the SuperNatural Inheritance project from Codecademy's Learn C# curriculum. 
It demonstrates various features of OOP including the use of objects and inheritance. 
This project has a Pupil class, which is inherited by the Mage class. The Mage class is further inherited by the Archmage class. 
All three classes use the Storm class to cast various spells; for instance, a Pupil can cast a weak wind storm while a Mage can cast a weak wind storm and a weak rain storm.
Because all three classes share certain attributes (such as a title and weak wind storm), the pupil is at the top of the hierarchy. This allows the Mage and Archmage to inherit the title field as well as the weak wind storm (which they should also be capable of). This therefore allows the Mage and Archmage to have their own unique spells aside from those at the Pupil level.
It may seem unintuitive to have the Pupil at the top of the hierarchy and the Archmage at the bottom, but reversing the order would allow an instance of the Pupil class to use spells reserved for an Archmage.
