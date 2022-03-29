import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, View } from 'react-native';

export default function App() {
  return (
    <View style={styles.container}>
      <Text style={styles.titleText}>Holiwis</Text>
      <Text> Que emocionante</Text>
      <StatusBar style="auto" />
    </View>
  );

}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#800000',
    alignItems: 'center',
    justifyContent: 'center',
  },

  titleText:{
    fontSize: 15
  }
});