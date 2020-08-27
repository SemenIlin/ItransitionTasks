<?php
function proj()
{	
	require_once ('Employees/Employee.php');
	require_once ('Employees/Designer.php');
	require_once ('Employees/SeniorDeveloper.php');
	require_once ('Employees/MiddleDeveloper.php');
	require_once ('Employees/Imposer.php');
		   
	require_once ('Payment/PaymentTypeInterface.php');
	require_once ('Payment/FixedRate.php');
	require_once ('Payment/HourlyRate.php');
		   
	require_once ('Projects/ProjectInterface.php');
	require_once ('Projects/Project.php');
	
	
    $designer = new Designer(new FixedRate(3000), "Ivan ","Sobolev ", "Sergeevich ");
    $seniorDeveloper = new SeniorDeveloper(new HourlyRate(10,65), " Sergey ","Ivanov ","Artem'evich ");
    $middleDeveloper1 = new MiddleDeveloper(new FixedRate(1000), " Sergey ", "Petrov ", "Semenovich ");
    $middleDeveloper2 = new MiddleDeveloper(new FixedRate(1000), " Yuliya ","Andreevna ", "Dmitreevna ");
    $imposer = new Imposer(new HourlyRate(5,120)," Kristsina "," Fedorchuk ","Sergeevna ");

    $projectX = new Project();
    $projectX->addEmployee($designer);
    $projectX->addEmployee($seniorDeveloper);
    $projectX->addEmployee($middleDeveloper1);
    $projectX->addEmployee($middleDeveloper2);
    $projectX->addEmployee($imposer);
	
	$space = " ";

	foreach ($projectX->getListEmployees() as $value)
	{
		echo $value->getFirstName(), $value->getLastName(), $value->getPatronymic(), $value->getSalary();
		echo $space;
	}
	echo "total price ";
	echo $projectX->getTotalCostOfProject();
}

eval($argv[1].';');

?>