<?php


abstract class Employee
{
    private string $firstName;
    private string  $lastName;
    private string $patronymic;

    public function __construct(string $firstName, string $lastName, string $patronymic)
    {
        $this->firstName = $firstName;
        $this->lastName = $lastName;
        $this->patronymic = $patronymic;
    }

    public function getFirstName() : string
    {
        return $this->firstName;
    }

    public function getLastName() : string
    {
        return $this->lastName;
    }

    public function getPatronymic() : ?string
    {
        return $this->patronymic;
    }

    public function setFirstName(string $firstName) : void
    {
         $this->firstName = $firstName;
    }

    public function setLastName(string $lastName) : void
    {
        $this->lastName = $lastName;
    }

    public function setPatronymic(string $patronymic) : void
    {
        $this->patronymic = $patronymic;
    }

    abstract public function getSalary() : float;
}