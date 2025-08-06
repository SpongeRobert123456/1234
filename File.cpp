#include <iostream>
#include <string>
#include <ctime>
#include <cstdlib>

int main() {
  srand(time(0));

  int random = rand() % 7;

  int userGuess;
  cout << "Guess a number between 1 to 6: ";
  cin >> userGuess;
  cout << "\n";

  if (random == 0) {
    random++;
  }

  if (userGuess == random) {
    cout << "You win. the number was: " << random;
  } else {
    cout << "You lost, the number was: " << randoml
  }
}
