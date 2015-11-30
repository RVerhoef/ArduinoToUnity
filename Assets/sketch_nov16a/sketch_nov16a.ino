int UD = 0;
int LR = 0;

void setup() {
  Serial.begin(9600);
}

void loop() {
  UD = analogRead(A0);
  LR = analogRead(A1);
  Serial.print(UD);
  Serial.print("|");
  Serial.println(LR);   
  delay(20);
}
