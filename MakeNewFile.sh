cp ./Problems/Algorithms/Template.cs ./Problems/Algorithms/$1.cs

sed -i '' 's/Template/'$1'/g' ./Problems/Algorithms/$1.cs