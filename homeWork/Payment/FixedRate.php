<?php

require 'Payment/PaymentTrait.php';

class FixedRate implements ITypePayment
{
    use PaymentTrait;
}