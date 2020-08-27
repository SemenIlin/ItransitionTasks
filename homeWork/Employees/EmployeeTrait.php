<?php


trait EmployeeTrait
{
    private PaymentTypeInterface $typePayment;

    public function  __construct(PaymentTypeInterface $payment, string $firstName, string $lastName, string $patronymic)
    {
        parent::__construct($firstName, $lastName, $patronymic);
        $this->typePayment = $payment;
    }

    public function getSalary() : float
    {
        return $this->typePayment->getPayment();
    }
}