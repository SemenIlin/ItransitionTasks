<?php


interface PaymentTypeInterface
{
    public function getPayment() : float;
    public function setPayment(float $amountOfPayment) : void;
}