<?php


trait PaymentTrait
{
    private float $amountOfPayment;

    public function __construct(float $amountOfPayment)
    {
        $this->amountOfPayment = $amountOfPayment;
    }

    public function getPayment() : float
    {
        return  $this->amountOfPayment;
    }
    public function setPayment(float $amountOfPayment) : void
    {
        $this->amountOfPayment = $amountOfPayment;
    }

}