#Numerical Differentiation using Euler's Method

import math

def f(x,y):
    return (math.sin(x+y) - math.exp(x))

#(x0,y0) is initial point and h is the step value
def Euler(x,y,h):
    cnt=0
    print('X: ',x,' Y: ',y,' Slope(dy/dx) :',f(x,y))
    while cnt<10:
        y=y+(h*f(x,y))
        x+=h
        print('X: ',x,' Y: ',y,' Slope(dy/dx) :',f(x,y))
        cnt+=1


print('---INITIAL POINT----')        
x0=int(input('Enter the point X:'))
y0=int(input('Enter the point Y:'))
h=float(input('Enter the step value(h):'))
Euler(x0,y0,h)


'''
OUTPUT:

---INITIAL POINT----
Enter the point X:0
Enter the point Y:4
Enter the step value(h):0.1
X:  0  Y:  4  Slope(dy/dx) : -1.7568024953079282
X:  0.1  Y:  3.8243197504692072  Slope(dy/dx) : -1.8103864498009508
X:  0.2  Y:  3.643281105489112  Slope(dy/dx) : -1.8669109257378973
X:  0.30000000000000004  Y:  3.4565900129153224  Slope(dy/dx) : -1.9268151730265985
X:  0.4  Y:  3.2639084956126627  Slope(dy/dx) : -1.990713233398781
X:  0.5  Y:  3.0648371722727847  Slope(dy/dx) : -2.059442106462883
X:  0.6  Y:  2.8588929616264966  Slope(dy/dx) : -2.1341215745572457
X:  0.7  Y:  2.6454808041707722  Slope(dy/dx) : -2.2162311733869355
X:  0.7999999999999999  Y:  2.4238576868320787  Slope(dy/dx) : -2.307713204535722
X:  0.8999999999999999  Y:  2.1930863663785063  Slope(dy/dx) : -2.4111158431243895
X:  0.9999999999999999  Y:  1.9519747820660673  Slope(dy/dx) : -2.529798199044265

'''
