using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly List<string> buffer = new List<string>();
        private bool HasCalculated = true;
        private bool HasPressedNumber = false;
        private ICalculatorService calculatorService = new CalculatorService();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddNumber(object sender, RoutedEventArgs e)
        {
            if (HasCalculated)
            {
                buffer.Clear();
            }

            string newBufferEntry;
            if (HasPressedNumber)
            {
                var currentNumberString = buffer.Last();
                newBufferEntry = currentNumberString + (sender as ContentControl).Content.ToString();
                buffer.Remove(buffer.Last());
            }
            else
            {
                newBufferEntry = (sender as ContentControl).Content.ToString();
            }

            buffer.Add(newBufferEntry);

            HasCalculated = false;
            HasPressedNumber = true;
            
            bool hasEquation = buffer.Count == 3;
            if (hasEquation)
            {
                this.Calculate();
            }

            this.ResultsTextBox.Text = buffer.Aggregate((s1, s2) => s1 + s2);
        }

        private void AddOperator(object sender, RoutedEventArgs e)
        {
            if (!HasPressedNumber)
            {
                return;
            }

            buffer.Add((sender as ContentControl).Content.ToString());

            HasPressedNumber = false;
            HasCalculated = false;
            this.ResultsTextBox.Text = buffer.Aggregate((s1, s2) => s1 + s2);
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            buffer.Clear();
            HasPressedNumber = false;
            this.ResultsTextBox.Text = "";
        }
        private void Calculate()
        {
            // parse strings
            double firstOperand = Double.Parse(buffer[0]);
            double secondOperand = Double.Parse(buffer[2]);

            // call service
            string answer = null;
            try
            {
                switch (buffer[1])
                {
                    case "+":
                        answer = calculatorService.Add(firstOperand, secondOperand).ToString();
                        break;
                    case "-":
                        answer = calculatorService.Subtract(firstOperand, secondOperand).ToString();
                        break;
                    case "x":
                        answer = calculatorService.Multiply(firstOperand, secondOperand).ToString();
                        break;
                    case "÷":
                        answer = calculatorService.Divide(firstOperand, secondOperand).ToString();
                        break;
                }
                HasPressedNumber = true;
            }
            catch (MathException e)
            {
                answer = e.Message;
                HasPressedNumber = false;
            }

            buffer.Clear();
            buffer.Add(answer);
            HasCalculated = true;
        }
    }
}
